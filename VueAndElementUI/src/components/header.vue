<template>
 <el-row>
   <el-col :span="4" class="logo">
     <img src="../assets/logo.png">
   </el-col>
<el-col :span="16">
      <el-menu
        :default-active="activeIndex2"
        class="menu"
        router
        mode="horizontal"
        @select="handleSelect"
        background-color="#545c64"
        text-color="#fff"
        active-text-color="#ffd04b">
      <template
          v-for="route in $router.options.routes"
          v-if="!route.hidden">

          <!-- 循环没有children的路由 -->
          <el-menu-item
            v-if="!route.hasChild"
            :key="route.path"
            :index="route.path" >
            {{ route.name }}
          </el-menu-item>
          <!-- 循环有children的路由 -->
          <el-submenu v-else  :key="route.path" :index="route.path">
            <template slot="title">{{ route.name }}</template>
            <el-menu-item
              v-for="child in route.children"
              :index="child.path"
              :key="child.path">
              {{ child.name }}
            </el-menu-item>
          </el-submenu>

        </template>

      </el-menu>
    </el-col>
    <!-- 右边用户信息以及登陆注册 -->
    <el-button-group>
      <el-button type="danger" size="small" round >login</el-button>
      <el-button type="success" size="small" round >regin</el-button>
    </el-button-group>
  </el-row>

</template>
<script>
export default {
  methods: {
    handleSelect () {
      console.log('菜单选择之后的回调操作')
    }
  }
}
</script>

<style scoped>

</style>
