<template>
  <v-app>
    <div>
      <v-app-bar color="primary" >
        <v-toolbar-title >Goals Tracker</v-toolbar-title>
        <v-spacer></v-spacer>
        <v-switch inset></v-switch>
      </v-app-bar>
    </div>
    <v-content class="d-flex justify-center align-center">
      <div v-if="isCategoryFormVisible">
        <CategoryForm @close-form="toggleForm" :isCategoryFormVisible="isCategoryFormVisible"></CategoryForm>
      </div>
      <div v-else>
        <div v-if="categories.length > 0" class="d-flex justify-space-around align-center">
          <div v-for="category in categories" v-bind:key="category.categoryName">
            <Category :category="category"/>
          </div>
        </div>
        <div v-else class="d-flex justify-center align-center">
          <p>To Start, add a category<br>
            <small>Ex: Health, Beauty, Books...</small>
          </p>
        </div>
      </div>
      <div class="add-btn-container" v-if="!isCategoryFormVisible">
        <v-tooltip top>
          <template v-slot:activator="{ on }">
            <v-btn @click="toggleForm" fab color="primary">
              <v-icon dark>mdi-plus</v-icon>
            </v-btn>
          </template>
          <span>Add New Category</span>
        </v-tooltip>
      </div>
    </v-content>

    <v-footer class="d-flex flex-column justify-center">
      <small> Created by Alessia Miccoli with <v-icon small>mdi-heart</v-icon><v-icon small>mdi-vuejs</v-icon><v-icon small>mdi-vuetify</v-icon></small>
    </v-footer>

  </v-app>
</template>

<script>
import Category from './components/Category';
import CategoryForm from './components/CategoryForm';

import { mapState } from 'vuex';

export default {
  name: 'App',
  components: {
    Category,
    CategoryForm,
  },
  data: () => ({
    isCategoryFormVisible : false,
  }),
  computed: mapState([
    'categories'
  ]),
  methods: {
    addCategory(){
      this.toggleForm()
      this.$store.commit('addCategory')
    },
    toggleForm(){
      this.isCategoryFormVisible = !this.isCategoryFormVisible
    }
  }
};
</script>

<style>

  .category{
    width: 30vmin;
    height: 30vmin;
    flex-wrap: wrap;
  }

  .add-btn-container{
    width: 100vw;
    margin-top: 20px;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .progress-container{
    padding: 10px;
  }

  .item-container{
     width: 100vw; 
  }
</style>
