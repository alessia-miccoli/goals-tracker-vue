<template>
    <v-card class="category"> 
      <v-card-title>{{category.categoryName}}</v-card-title>
      <v-card-subtitle>{{category.goals.length}} goals</v-card-subtitle>
      <div class="progress-container">
        <v-progress-linear
            :striped="true"
            :value="category.progress"
            height="15"
            reactive>
            {{category.progress}}%
        </v-progress-linear>
      </div>
      <v-card-actions>
        <v-btn text @click="removeCategory">Delete</v-btn>
      </v-card-actions>
  </v-card>
</template>
<script>

export default {
  name: 'Category',
  props: ['category'],
  data: () => ({
    //
  }),
  methods: {
    removeCategory(category){
      this.$emit('remove-category', category);
    }
  }
};
</script>

<style scoped>
  .progress-container{
    margin-bottom: 15%;
  }
</style>
