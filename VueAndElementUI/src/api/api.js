import axios from 'axios'
let base = ' https://www.easy-mock.com/mock/5abb324dbd48f03d3743b5a5/Learning'
// 注册接口
export const ReginUser = params => {
  return axios.post(`${base}/users`, params)
}

// 登录接口
export const LoginUser = params => {
  return axios.post(`${base}/login`, params)
}
