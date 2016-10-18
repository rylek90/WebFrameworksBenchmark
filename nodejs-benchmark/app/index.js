const express = require('express')
const app = express()
const port = 8000
const host = "127.0.0.1"

const primes = require('./primes')

app.use(express.static('public'));

app.get('/primes', (request, response) => {
	response.setHeader('Content-Type', 'application/json');
	response.send(JSON.stringify(primes.checkPrimes()));
});

app.get('/generate', (request, response) => {
  response.setHeader('Content-Type', 'application/json');
  response.send(JSON.stringify(primes.generate()));
});

app.listen(port, host, (err) => {
  if (err) {
    return console.log('something bad happened', err)
  }

  console.log(`server is listening on ${host}:${port}`)
})