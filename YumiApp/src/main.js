import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify';
import axios from 'axios'
import CategoriesStore from '@/stores/CategoriesStore.js'


Vue.prototype.$http = axios
Vue.prototype.$categories = CategoriesStore

Vue.config.productionTip = false

new Vue({
  router,
  vuetify,
  
  render: h => h(App)
}).$mount('#app')
