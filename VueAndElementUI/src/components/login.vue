<template>
 <el-main>
   <el-form :model="LoginForm" ref="LoginForm" :rules="rule" label-width="0" class="login-form">
     <h3>用户登录系统</h3>
     <el-form-item prop="username">
       <el-input type="text" v-model="LoginForm.username" placeholder="username"></el-input>
     </el-form-item>
      <el-form-item prop="password">
       <el-input type="password" v-model="LoginForm.password" placeholder="password"></el-input>
     </el-form-item>
     <el-form-item label="">
       <el-button type="success"
          class="submitBtn"
          round
          @click.native.prevent="submit()"
          :loading="logining">
          登录
        </el-button>
       <el-button type="danger" class="submitButton" round @click.native.prevent="reset()">重置</el-button>
       <hr>
       <p>还没有账号，马上去<span class="to" @click="toregin()">注册</span></p>
     </el-form-item>
   </el-form>
 </el-main>
</template>
<script>
import {LoginUser} from '../api/api'
export default {
  data () {
    return {
      LoginForm: {
        username: '',
        password: ''
      },
      logining: false,
      rule: {
        username: [{
          reqired: true,
          max: 14,
          min: 3,
          message: '用户名是必须的，长度为3-14位',
          trigger: 'blur'
        }],
        password: [
          {
            required: true,
            message: '密码是必须的！',
            trigger: 'blur'
          }
        ]
      }}
  },
  methods: {
    submit () {
      this.$refs.LoginForm.validate(valid => {
        if (valid) {
          this.logining = true
          let LoginParams = {
            username: this.LoginForm.username,
            password: this.LoginForm.password
          }

          LoginUser(LoginParams).then(res => {
            this.logining = false
            // 根据返回的 result 判断是否成功，注意此处要 res.data.data
            let {result, user} = res.data.data
            if (result !== true) {
              this.$message({
                type: 'error'
              })
            } else {
              this.$message({
                type: 'success'
              })
              // 将返回的数据注入 sessionStorage
              sessionStorage.setItem('user', JSON.stringify(user))
              // 跳转到我的信息的页面
              this.$router.push('/manager/my')
            }
          })
        } else {
          console.log('submit error')
        }
      })
    },
    reset () {
      this.$refs.LoginForm.resetFields()
    },
    toregin () {
      this.$router.push('/regin')
    }
  }
}
</script>

<style scoped>
.login-form {
  margin: 20px auto;
  width: 310px;
  background: #fff;
  box-shadow: 0 0 35px #B4BCCC;
  padding: 30px 30px 0 30px;
  border-radius: 25px;
}
.submitBtn {
  width: 65%;
}
.to {
  color: #67C23A;
  cursor: pointer;
}
</style>
