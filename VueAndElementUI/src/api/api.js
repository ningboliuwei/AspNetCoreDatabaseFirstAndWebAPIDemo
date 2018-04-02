import axios from 'axios'
let base = 'http://localhost:52139/api'

// 获取菜品类别
export const Categories = params => {
  return axios.get(`${base}/categories`, params)
}
