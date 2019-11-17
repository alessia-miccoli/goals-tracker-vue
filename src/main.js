import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import Vuex from 'vuex'

Vue.use(Vuex)
Vue.config.productionTip = false

const store = new Vuex.Store({
  state: {
    categories : []
  },
  mutations: {
    addCategory (state) {
      var newCategory = {
        categoryName : '',
        subCategories : [],
        goals: [],
        progress : 0
      }

      state.categories.push(newCategory)
    }
  }
})

new Vue({
  vuetify,
  store,
  render: h => h(App)
}).$mount('#app')
