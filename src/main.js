import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import Vuex from 'vuex'
const axios = require('axios');

Vue.use(Vuex)
Vue.config.productionTip = false

const store = new Vuex.Store({
  state: {
    categories : []
  },
  mutations: {
    addCategory (state, category) {
      state.categories.push(category);
    },
    deleteCategory(state, id){
      state.categories.splice(state.categories.findIndex(category => category.id == id), 1);
    }
  },
  actions:  {
    getCategories ({ state }){
      axios.get("https://gltrckr.herokuapp.com/api/categories").then(res => {
        state.categories = res.data.payload;
      })
    },
    addCategoryAsync({ commit }, category){
      axios.post("https://gltrckr.herokuapp.com/api/categories", category).then(() => {
        commit('addCategory', category)
      } )
    },
    deleteCategoryAsync({ commit }, id){
      axios.delete(`https://gltrckr.herokuapp.com/api/categories/${id}`).then(() => {
        commit('deleteCategory', id);
      })
    }
  },
  getters: {
    filterByCategoryName: (state) => (categoryName) => {
      return state.categories.filter(category => category.categoryName === categoryName)
    }
  }
})

new Vue({
  vuetify,
  store,
  render: h => h(App)
}).$mount('#app')
