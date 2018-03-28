<template>
  <div id="app">
    <el-container>
<el-header><header-ly></header-ly></el-header>
<el-main>
   <transition name="el-zoom-in-center">
  <router-view/></transition>
</el-main>
<el-footer><footer-ly></footer-ly></el-footer>
    </el-container>
  </div>
</template>

<script>
import HeaderLy from './components/header.vue'
import FooterLy from './components/footer.vue'

export default {
  name: 'App',
  components: {
    HeaderLy,
    FooterLy
  }
}
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
