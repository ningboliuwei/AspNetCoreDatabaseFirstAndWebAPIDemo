import Vue from 'vue'
import Router from 'vue-router'
// 引入组件
import Home from '../components/page/home'
import Categories from '../components/page/admin/Categories.vue'
import Page404 from '../components/page/page404.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: '首页',
      component: Home
    },
    {
      path: '/admin',
      name: '管理后台',
      hidden: true,
      hasChild: true,
      children: [
        {
          path: '/admin/categories',
          name: '菜品类别',
          component: Categories
        }]
    },
    {
      path: '*',
      hidden: true,
      component: Page404
    }
  ]
})
