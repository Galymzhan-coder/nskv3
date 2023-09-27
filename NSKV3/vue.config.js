const fs = require('fs');

module.exports = {
    devServer: {
        https: {
            key: fs.readFileSync('../cert/server.cert'),
            cert: fs.readFileSync('../cert/server.pem'),
            ca: fs.readFileSync('../cert/cacert.pem')
        },
        public: 'https://localhost:7006',
        writeToDisk: true
    },
    outputDir: '../wwwroot',
    indexPath: '../wwwroot/index.html'
}
