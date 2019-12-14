const axios = require('axios');
let stateCategories = [];
let categories = [];

let value = {
  "name": "Prova", 
  "goals": []
};

axios.post("https://gltrckr.herokuapp.com/api/categories", value)
.then(res => console.log("risposta ", res)).catch(e =>{
  console.log("errore ", e)
});

axios.get("https://gltrckr.herokuapp.com/api/categories").then(res => {
  categories = res.data.payload;
  categories.forEach(category => {
    stateCategories.push(category)
  })
  console.log(stateCategories)
});





