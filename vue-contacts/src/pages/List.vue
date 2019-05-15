<template>
  <div>
    <navigation-bar>
      <template v-slot:left-side>
        <navigation-link to="/">Form</navigation-link>
      </template>
      <template v-slot:right-side>
        <navigation-search v-on:search="doSearch"/>
      </template>
    </navigation-bar>
    <h2>Contacts</h2>
    <center><b-spinner label="Spinning" v-if="contacts===null"></b-spinner></center>
    <contact-list ref="list" v-if="contacts!==null" :list="contacts" />
  </div>
</template>

<script>
import NavigationBar from '../layouts/NavigationBar.vue'
import NavigationLink from '../layouts/NavigationLink.vue'
import NavigationSearch from '../layouts/NavigationSearch.vue'
import ContactList from '../components/ContactList.vue'
import {HTTP} from '../http'

export default {
  components: {
    NavigationBar,
    NavigationLink,
    NavigationSearch,
    ContactList
  },
  data () {
    return {
      contacts: null
    }
  },
  methods: {
    doSearch (search) {
      this.contacts = null

      HTTP({method: 'get', url: '/contacts?search=' + encodeURIComponent(search || '')})
        .then(response => {
          this.contacts = response.data || []
        })
        .catch(e => {
          this.contacts = []
          alert(e)
        })
    }
  },
  created: function () {
    this.doSearch()
  }
}
</script>
