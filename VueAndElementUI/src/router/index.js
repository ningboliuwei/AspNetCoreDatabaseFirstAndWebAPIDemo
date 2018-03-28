import Vue from 'vue'
import Router from 'vue-router'
// 引入组件
import Home from '../components/home'
import Login from '../components/login'
import Regin from '../components/regin'
import Products from '../components/page/products'
import FAQ from '../components/page/FAQ'
import Manger from '../components/page/manager.vue'
import My from '../components/page/manager/my.vue'
import Send from '../components/page/manager/send.vue'
import MyHistory from '../components/page/manager/history.vue'
import Page404 from '../components/page/404.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: '首页',
      component: Home
    },
    {
      path: '/login',
      name: '',
      hidden: true,
      component: Login
    },
    {
      path: '/regin',
      name: '',
      hidden: true,
      component: Regin
    },
    {
      path: '/products',
      name: '商品',
      component: Products
    },
    {
      path: '/FAQ',
      name: '常见问题',
      component: FAQ
    },
    {
      path: '/manager',
      name: '我的工作台',
      component: Manger,
      hasChild: true,
      children: [
        {
          path: '/manager/my',
          name: '我的信息',
          component: My
        },
        {
          path: '/manager/send',
          name: '发货管理',
          component: Send
        },
        {
          path: '/manager/history',
          name: '发货记录',
          component: MyHistory
        }
      ]
    },
    {
      path: '*',
      hidden: true,
      component: Page404
    }
  ]
})
