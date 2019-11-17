<template>

    <v-card class="category"
        > 

    <v-card-title >Code</v-card-title>
    <v-card-subtitle>3 sub-categories</v-card-subtitle>
    <div class="progress-container">
    <v-progress-linear
        :striped="true"
        value="80"
        height="15"
        reactive>
        80%
    </v-progress-linear>
    </div>
  </v-card>

</template>

<script>
// import HelloWorld from './components/HelloWorld';

export default {
  name: 'Category',

  components: {
    // HelloWorld,
  },

  data: () => ({
    //
  }),
};
</script>

<style>

</style>
