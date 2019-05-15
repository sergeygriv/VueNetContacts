<template>
  <div>
    <navigation-bar>
      <template v-slot:left-side>
        <navigation-link to="/list">List</navigation-link>
      </template>
    </navigation-bar>
    <h2>Contact Form</h2>
    <contact-form v-on:submit="addContact" ref="form" />
  </div>
</template>

<script>
import NavigationBar from '../layouts/NavigationBar.vue'
import NavigationLink from '../layouts/NavigationLink.vue'
import ContactForm from '../components/ContactForm.vue'
import {HTTP} from '../http'

export default {
  components: {
    NavigationBar,
    NavigationLink,
    ContactForm
  },
  methods: {
    async addContact (data) {
      try {
        this.$refs.form.disabled = true
        await HTTP({method: 'post', url: '/contacts', data: data})
        this.$refs.form.clear()
      } catch (error) {
        alert(error)
      }
      this.$refs.form.disabled = false
    }
  }
}
</script>
