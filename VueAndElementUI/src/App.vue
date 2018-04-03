<template>
  <div id="app">
    <template>
  <v-container grid-list-md text-xs-center>
    <v-layout row wrap>
    <v-btn small color="error">Error</v-btn>
      <v-flex xs12>
       <template>
  <v-data-table
  :headers="headers"
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
import {getCategories} from './api/api'
export default {
  name: 'App',
  components: {
  },
  data: function () {
    return {
      headers: [
        {
          text: '菜品类别 ID',
          align: 'left',
          sortable: false,
          value: 'id'
        },
        { text: '菜品类别', value: 'categoryName' }
      ],
      items: [] }
  },
  mounted: async function () {
    const result = await getCategories({})
    this.items = result.data.data
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
