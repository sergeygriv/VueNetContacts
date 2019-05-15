<template>
  <div>
    <b-navbar toggleable="lg" type="dark" variant="info">
      <b-navbar-nav>
        <slot name="left-side"></slot>
      </b-navbar-nav>
      <b-navbar-nav class="ml-auto">
        <slot name="right-side"></slot>
      </b-navbar-nav>
    </b-navbar>
  </div>
</template>
