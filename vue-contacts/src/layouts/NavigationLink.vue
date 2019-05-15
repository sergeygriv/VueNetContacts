<template>
  <b-nav-item v-bind:to="to">
    <slot></slot>
  </b-nav-item>
</template>

<script>
export default {
  name: 'NavigationLink',
  props: ['to']
}
</script>
