<template>
  <div class="list">
    <center v-if="list && list.length == 0">No contacts</center>
    <b-table hover :items="list" :fields="fields" v-if="list && list.length"></b-table>
  </div>
</template>

<script>
export default {
  props: ['list'],
  data () {
    return {
      list2: [],
      fields: {
        Name: {
          sortable: true
        },
        Description: {
          sortable: false
        },
        Source: {
          sortable: true
        },
        VisitDate: {
          sortable: true,
          formatter (v) {
            if (typeof v === 'string') {
              v = new Date(v)
            }

            return v && v.toDateString()
          }
        },
        AcceptedTerms: {
          sortable: true,
          formatter (v) {
            return v ? '☑' : '☐'
          }
        },
        Gender: {
          sortable: true,
          formatter (v) {
            return v === 'm' ? 'Male' : v === 'f' ? 'Female' : ''
          }
        }
      }
    }
  }
}
</script>
