import Vue from 'vue'
import Router from 'vue-router'
import Form from '@/pages/Form'
import List from '@/pages/List'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Form',
      component: Form
    },
    {
      path: '/list',
      name: 'List',
      component: List
    }
  ]
})
