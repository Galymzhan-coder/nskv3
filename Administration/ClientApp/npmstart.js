/* eslint-disable no-undef */
const { execSync } = require('child_process')
const path = require('path')

const clientAppPath = path.join(__dirname, 'ClientApp')
execSync('npm run serve', { cwd: clientAppPath, stdio: 'inherit' })
