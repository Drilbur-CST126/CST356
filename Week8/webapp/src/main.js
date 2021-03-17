import Vue from 'vue'
import Axios from 'axios'
import VueAxios from 'vue-axios'
import router from './router'
import App from './App.vue'

Vue.config.productionTip = false
Vue.use(VueAxios, Axios);

new Vue({
  render: h => h(App),
  router
}).$mount('#app')