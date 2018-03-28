<template>
 <el-row>
   <el-col :span="4" class="logo">
     <img src="../assets/logo.png">
   </el-col>
<el-col :span="16">
      <el-menu

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
    <el-col :span="4" class="user">
      <!-- 根据logined值的真假来判断是显示登录按钮还是用户信息
      以后根据登录状态来改变 -->
      <el-button-group v-if="!logined" >
        <el-button  class="button" @click.native="tologin" type="danger" size="small" round >login</el-button>
        <el-button  class="button" @click.native="toregin" type="success" size="small" round >regin</el-button>
      </el-button-group>
      <div v-else>
        <el-dropdown>
          <img class="avatar" src="../assets/avatar.jpg" alt="">
          <el-dropdown-menu slot="dropdown">
            <el-dropdown-item>李小小</el-dropdown-item>
            <el-dropdown-item>我的工作台</el-dropdown-item>
            <el-dropdown-item divided>退出登录</el-dropdown-item>
          </el-dropdown-menu>
        </el-dropdown>
      </div>
    </el-col>
  </el-row>

</template>
<script>
export default {
  // ...
  data () {
    return {
      logined: false
    }
  },
  methods: {
    handleSelect () {
      console.log()
    },
    tohome () {
      this.$router.push('/')
      console.log('home')
    },
    tologin () {
      this.$router.push('/login')
    },
    toregin () {
      this.$router.push('/regin')
    }
  }
}
</script>
<style scoped>
.header {
  width: 100%;
  height: 60px;
  margin: 0;
  background: #fff;
  position: fixed;
  top: 0;
  left: 0;
  box-shadow: 0 0 25px #666;
}
.logo img {
  width: 60px;
  height: 60px;
  cursor: pointer;
}
.button {
  margin: 15px 0;
}
.avatar {
  width: 40px;
  height: 40px;
  border-radius: 20px;
  margin: 10px 0;
  cursor: pointer;
}
</style>
