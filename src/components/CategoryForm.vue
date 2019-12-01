<template>
  <v-card v-if="isCategoryFormVisible" class="form">
    <v-btn @click="closeForm" class="float-right" x-small text fab color="primary"><v-icon >mdi-close</v-icon></v-btn>
    <v-form>
      <v-text-field
        v-model="categoryName"
        placeholder="Category Name"
      ></v-text-field>
      <div class="d-flex flex-column align-center buttons-container">
        <div class="d-flex flex-column">
          <div v-if="goals.length > 0">
            <p>Goals for '{{categoryName}}':</p>
          </div>
          <div v-show="goals.length > 0" v-for="goal in goals" :key="goal.description" class="d-flex justify-start">
            <v-checkbox v-model="goal.done"></v-checkbox>
            <v-text-field v-if="goal.editModeOn"
              v-model="newDescription"
              :placeholder="goal.description"
            ></v-text-field>
            <p v-else>{{goal.description}}</p>
            <v-tooltip top>
            <template v-slot:activator="{ on }">
              <v-btn fab small color="primary" v-on="on">
                <v-icon v-if="!goal.editModeOn" small dark @click="toggleEditMode(goal)">mdi-pencil</v-icon>
                <v-icon v-else small dark @click="updateGoal(goal)">mdi-check-bold</v-icon>
              </v-btn>
            </template>
            <span>Edit goal</span>
          </v-tooltip>
          <v-tooltip top>
            <template v-slot:activator="{ on }">
              <v-btn fab small color="primary" v-on="on" @click="removeGoal(goal)">
                <v-icon small dark>mdi-delete</v-icon>
              </v-btn>
            </template>
            <span>Remove goal</span>
          </v-tooltip>
          </div>
          <div v-if="goals.length > 0">
            <v-divider></v-divider>
          </div>
          <div class="d-flex align-center justify-center">
            <p>New Goal:</p>
            <v-text-field
              v-model="description"
              placeholder="Goal Description"
            ></v-text-field>
            <v-tooltip top>
            <template v-slot:activator="{ on }">
              <v-btn fab small color="primary" v-on="on" @click="newGoal">
                <v-icon x-small dark>mdi-plus</v-icon>
              </v-btn>
            </template>
            <span>Add to goal list</span>
          </v-tooltip>
          </div>
        </div>
        <v-tooltip bottom>
          <template v-slot:activator="{ on }">
            <v-btn fab color="primary" v-on="on" @click="addCategory">
              <v-icon dark>mdi-content-save</v-icon>
            </v-btn>
          </template>
          <span>Save</span>
        </v-tooltip>
      </div>
    </v-form>
  </v-card>
</template>

<script>
export default {
  name: 'CategoryForm',
  props: ['isCategoryFormVisible'],
  methods: {
    closeForm(){
      this.$emit('close-form')
    },
    addCategory(){
      const category = {
        categoryName: this.categoryName,
        goals: this.goals,
        progress: this.progress
      }
      this.$store.commit('addCategory', category);
      this.closeForm();
    },
    newGoal(){
      const goal = {
        description: this.description,
        done: false,
        weight: this.weight ? this.weight : 100 - 100/(this.goals.length),
        editModeOn: false
      }
      this.goals.push(goal);
      this.description = '';
      this.weight = null;
      this.done = false;
    },
    removeGoal(goal){
      this.goals.splice(this.goals.findIndex(el => el == goal), 1);
    },
    toggleEditMode(goal){
      goal.editModeOn = !goal.editModeOn;
    },
    updateGoal(goal){
      if(this.newDescription!== ''){
        goal.description = this.newDescription;
        this.newDescription = '';
      }
      this.toggleEditMode(goal);
    },
  },
  data: () => ({
    categoryName: '',
    goals: [],
    description: '',
    done: false,
    weight: null,
    newDescription: '',
    newWeight: null,
  }),
  computed: {
    progress(){
      return 100;
    }
  }
};
</script>

<style scoped>

    .buttons-container *{
        margin: 10px;
    }

    .form{
        padding: 10px;
        width: 50%;
        margin-left: 25%;
    }
</style>
