import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    isLoggedIn: false
  },
  mutations: {
    // 注意参数要用 state
    SignIn (state) {
      state.isLoggedIn = true
    },
    SignOut (state) {
      state.isLoggedIn = false
    }
  },
  actions: {
    SignIn (context) {
      context.commit('SignIn')
    },
    SignOut (context) {
      context.commit('SignOut')
    }
  }
})
