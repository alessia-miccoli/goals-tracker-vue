import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import Vuex from 'vuex'

Vue.use(Vuex)
Vue.config.productionTip = false

const store = new Vuex.Store({
  state: {
    categories : [ ]
  },
  mutations: {
    addCategory (state, category) {
      state.categories.push(category)
    },
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
