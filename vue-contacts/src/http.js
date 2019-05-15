import axios from 'axios'

export const HTTP = axios.create({
  baseURL: 'http://localhost:49188/api/',
  timeout: 1000
})
