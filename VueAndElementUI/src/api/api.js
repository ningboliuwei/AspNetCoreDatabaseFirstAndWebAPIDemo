import axios from 'axios'
let base = 'http://localhost:52140/api'

// 获取菜品类别
export const getCategories = params => {
  return axios.get(`${base}/categories`, params)
}

// 新增菜品类别
export const postCategorie = params => {
  return axios.post(`${base}/categories`, params)
}
