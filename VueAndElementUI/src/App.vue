<template>
  <div id="app">
    <template>
  <v-container grid-list-md text-xs-center>
    <v-layout row wrap>
      <v-flex xs12>
       <template>
  <v-data-table
    :items="items"
    hide-actions
    class="elevation-1"
  >
    <template slot="items" slot-scope="props">
      <td>{{ props.item.id }}</td>
      <td class="text-xs-right">{{ props.item.categoryName }}</td>
    </template>
  </v-data-table>
</template>
      </v-flex>
    </v-layout>
  </v-container>
</template>

</div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'App',
  components: {
  },
  data: function () {
    return { items: [] }
  },
  mounted: function () {
    axios.get(`http://localhost:52139/api/categories`).then(result => {
      this.items = result.data.data
    })
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
