<template>
  <b-nav-form @submit.prevent="$emit('search', search)">
    <b-form-input size="sm" class="mr-sm-2" placeholder="Search" v-model="search"></b-form-input>
    <b-button size="sm" class="my-2 my-sm-0" v-on:click="$emit('search', search)">Search</b-button>
  </b-nav-form>
</template>

<script>
export default {
  data: function () {
    return {
      search: ''
    }
  }
}
</script>
