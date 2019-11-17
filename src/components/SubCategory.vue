<template>
    <div id="sub-category">

    <v-card> 
        <v-card-title>Code</v-card-title>
        <v-divider></v-divider>
        <v-list>
        <v-list-item>
            <div class="item-container">
            <v-card-subtitle class="subcategory-title">
                <a href="#">#100DaysOfCode</a>
            </v-card-subtitle>
            <v-card-subtitle>100 goals</v-card-subtitle>
            <div class="progress-container">
                <v-progress-linear
                value="24"
                height="25"
                reactive>
                    24%
                </v-progress-linear>
            </div>
            <v-divider></v-divider>
            </div>
        </v-list-item>
        <v-list-item>
            <div class="item-container">
            <v-card-subtitle class="subcategory-title">
                <a href="#">Udemy Courses</a>
            </v-card-subtitle>
            <v-card-subtitle>2 goals</v-card-subtitle>
            <div class="progress-container">
                <v-progress-linear
                value="95"
                height="25"
                reactive>
                    95%
                </v-progress-linear>
            </div>
            <v-divider></v-divider>
            </div>
        </v-list-item>

        <v-list-item>
            <div class="item-container">
            <v-card-subtitle class="subcategory-title">
                <a href="#">Front-End Book</a>
            </v-card-subtitle>
            <v-card-subtitle>560 goals</v-card-subtitle>
            <div class="progress-container">
                <v-progress-linear
                value="98"
                height="25"
                reactive>
                    98%
                </v-progress-linear>
            </div>
            </div>
        </v-list-item>

        </v-list>

    </v-card>

    </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld';

export default {
  name: 'SubCategory',

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
