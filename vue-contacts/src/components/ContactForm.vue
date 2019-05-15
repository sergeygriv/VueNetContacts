<template>
  <div class="contact-form">
      <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group id="input-group-2" label="Contact Name:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.Name"
          trim
          placeholder="Enter name"
          :state="nameState"
        ></b-form-input>
        <b-form-invalid-feedback>
          Enter at least 2 letters
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group
        id="input-group-1"
        label="Description"
        label-for="input-1"
      >
        <b-form-textarea
          id="input-1"
          v-model="form.Description"
          rows="3"
        ></b-form-textarea>
      </b-form-group>

      <b-form-group label="Gender">
        <b-form-radio-group
          v-model="form.Gender"
          :options="genders"
          name="gemder-radio"
          id="gemder-radio"
        ></b-form-radio-group>
      </b-form-group>

      <b-form-group id="input-group-5" label="Visit Date:" label-for="input-5">
        <datepicker
          id="input-5"
          name="input-5"
          v-model="form.VisitDate"
          required
          format="dd/MM/yyyy"
          :input-class="datepickerClass"
        ></datepicker>
        <b-form-invalid-feedback :state="dateState">
          Please select visit date
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group id="input-group-3" label="Source:" label-for="input-3">
        <b-form-select
          id="input-3"
          v-model="form.Source"
          :options="sources"
          :state="sourceState"
        ></b-form-select>
        <b-form-invalid-feedback>
          Please select item from list
        </b-form-invalid-feedback>
      </b-form-group>

      <b-form-group id="input-group-4">
        <b-form-checkbox v-model="form.AcceptedTerms">accepted the terms and use</b-form-checkbox>
      </b-form-group>

      <b-button type="submit" variant="primary" :disabled="disabled">Add</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
  </div>
</template>

<script>
import Datepicker from 'vuejs-datepicker'

export default {
  components: {
    Datepicker
  },
  data () {
    return {
      form: {
        Name: '',
        Description: '',
        Source: null,
        VisitDate: null,
        AcceptedTerms: false,
        Gender: 'm'
      },
      sources: [{ text: 'Select One', value: null }, 'Yandex', 'Google'],
      genders: [
        { text: 'Male', value: 'm' },
        { text: 'Female', value: 'f' }
      ],
      show: true,
      validation: false,
      disabled: false
    }
  },
  computed: {
    nameState () {
      if (!this.validation) return null
      return this.form.Name.length >= 2
    },
    sourceState () {
      if (!this.validation) return null
      return this.form.Source != null
    },
    dateState () {
      if (!this.validation) return null
      return this.form.VisitDate != null
    },
    isValid () {
      return this.nameState && this.sourceState && this.dateState
    },
    datepickerClass () {
      return {
        'form-control': true,
        'is-invalid': this.dateState === false,
        'is-valid': this.dateState === true
      }
    }
  },
  methods: {
    onSubmit (evt) {
      evt.preventDefault()
      this.validation = true
      if (this.isValid) {
        this.$emit('submit', this.form)
      }
    },
    onReset (evt) {
      evt.preventDefault()
      // Reset our form values
      this.clear()
      // Trick to reset/clear native browser form validation state
      this.show = false
      this.$nextTick(() => {
        this.show = true
      })
    },
    clear () {
      this.form.Description = ''
      this.form.Name = ''
      this.form.Source = null
      this.form.AcceptedTerms = false
      this.form.VisitDate = null
      this.form.Gender = 'm'
      this.validation = false
    }
  }
}

</script>
