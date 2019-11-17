<template>
  <v-card class="category"> 
    <v-form class="form">
      <v-text-field
        placeholder="Category Name"
        @input="$v.name.$touch()"
        @blur="$v.name.$touch()"
      ></v-text-field>
      <div class="d-flex flex-column buttons-container">
        <v-btn color="primary">Add sub-category</v-btn>  
        <v-btn color="primary">Add goal</v-btn>
      </div>
    </v-form>
  </v-card>
</template>

<script>
// import HelloWorld from './components/HelloWorld';

export default {
  name: 'CategoryForm',

  components: {
    // HelloWorld,
  },

  data: () => ({
    //
  }),
};
</script>

<style scoped>

    .buttons-container *{
        margin: 10px;
    }

    .form{
        padding: 10px;
    }

</style>
