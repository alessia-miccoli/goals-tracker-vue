import Vue from 'vue';
import Vuetify from 'vuetify/lib';

import colors from 'vuetify/lib/util/colors'

Vue.use(Vuetify);

export default new Vuetify({
    theme: {
        dark: true,
        themes: {
            dark: {
              primary: colors.teal.darken1, // #E53935
              secondary: colors.teal.lighten2, // #FFCDD2
              accent: colors.teal.lighten4, // #3F51B5
            },
        },
    },
});
