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

      <!-- <SubCategory></SubCategory> -->

      <!-- <div class="d-flex justify-space-around">
        <Category></Category>
      </div> -->
        <div class="d-flex justify-center align-center">
          <p>To Start, add a category<br>
            <small>Ex: Health, Beauty, Books...</small>
          </p>
        </div>
        <div class="add-btn-container">
          <v-btn fab color="primary">
            <v-icon dark>mdi-plus</v-icon>
          </v-btn>
        </div>
    </v-content>

    <v-footer class="d-flex flex-column justify-center">
      <small> Created by Alessia Miccoli with <v-icon small>mdi-heart</v-icon><v-icon small>mdi-vuejs</v-icon><v-icon small>mdi-vuetify</v-icon></small>
    </v-footer>

  </v-app>
</template>

<script src="https://cdn.jsdelivr.net/npm/vue@2.x/dist/vue.js"></script>
<script src="https://cdn.jsdelivr.net/npm/vuetify@2.x/dist/vuetify.js"></script>

<script>
import SubCategory from './components/SubCategory';
import Category from './components/Category'

export default {
  name: 'App',

  components: {
    SubCategory,
    Category,
  },

  data: () => ({
    //
  }),
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

  .subcategory-title{
    font-size: 2.5vmin!important;
  }

  .subcategory-title a{
    color: white !important;
    text-decoration: none;
  }

  .item-container{
     width: 100vw; 
  }
</style>
