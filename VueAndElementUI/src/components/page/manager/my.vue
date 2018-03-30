<template>
<div>
  <h1>my.data</h1>
  <h5>我的name：{{username}}</h5></div>
</template>
<script>
export default {
  data () {
    return { username: '' }
  },
  mounted () {
    // 从内存取出数据
    let user = sessionStorage.getItem('user')
    // 判断数据是否存在
    if (user) {
      console.log(user)
      user = JSON.parse(user)
      this.username = user.username
    }
  }
}
</script>
