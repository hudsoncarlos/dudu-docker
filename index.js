const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send(`Olá Docker! Estamos ativos e fritando na porta: ${port}`)
});

app.listen(port, () => {
  console.log(`App rodando na porta: ${port}`)
});