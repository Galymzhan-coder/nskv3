const { defineConfig } = require('@vue/cli-service')
const fs = require('fs')
const path = require('path')

const baseFolder =
  process.env.APPDATA !== undefined && process.env.APPDATA !== ''
    ? `${process.env.APPDATA}/ASP.NET/https`
    : `${process.env.HOME}/.aspnet/https`

const certificateArg = process.argv
  .map((arg) => arg.match(/--name=(?<value>.+)/i))
  .filter(Boolean)[0]
const certificateName = certificateArg ? certificateArg.groups.value : 'vueapp'

if (!certificateName) {
  console.error(
    'Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly.',
  )
  process.exit(-1)
}

const certFilePath = path.join(baseFolder, `${certificateName}.pem`)
const keyFilePath = path.join(baseFolder, `${certificateName}.key`)

module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    https: {
      key: fs.readFileSync(keyFilePath),
      cert: fs.readFileSync(certFilePath),
    },
    proxy: {
      '/api': {
        target: 'https://localhost:7006',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/api/, '/api'),
      },
    },
    //public: 'http://localhost:7006',
    //writeToDisk: true,
  },
  outputDir: 'ClientApp/dist',
  indexPath: 'ClientApp/dist/index.html',
  //port: 5002,
})
/*
module.exports = {
  devServer: {
    https: {
      key: fs.readFileSync(keyFilePath),
      cert: fs.readFileSync(certFilePath),
    },
    proxy: {
      '^/weatherforecast': {
        target: 'https://localhost:7196/'
      }
    },
    port: 5002
  }
}

const { defineConfig } = require('@vue/cli-service')
const fs = require('fs')

module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    https: {
      key: fs.readFileSync('cert/nsk.rsa'),
      cert: fs.readFileSync('cert/nsk.crt'),
      //key: fs.readFileSync('cert/server.key'),
      //cert: fs.readFileSync('cert/server.cert'),
      ca: fs.readFileSync('cert/cacert.pem'),
    },
    proxy: {
      '/api': {
        target: 'https://localhost:7006',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/api/, '/api'),
      },
    },
    //public: 'http://localhost:7006',
    //writeToDisk: true,
  },
  outputDir: '../wwwroot',
  indexPath: '../wwwroot/index.html',
  //port: 5002,
})
*/
