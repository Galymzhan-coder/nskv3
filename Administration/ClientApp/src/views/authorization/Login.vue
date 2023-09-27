<template>
  <div class="auth">
    <div class="logo">
      <img src="@/assets/images/authorization/logo_rounded.png" alt="" />
    </div>
    <div class="text-center mt-3 name">NSK</div>
    <Form
      class="p-2 mt-0"
      @submit="loginHandler(username, password)"
      :validation-schema="schemaRules"
      v-slot="{ errors /*, isSubmitting */ }"
    >
      <div class="form-field">
        <span class="far fa-user"></span>
        <Field
          type="text"
          name="username"
          placeholder="Имя пользователя"
          autocomplete="off"
          v-model="username"
        />
      </div>
      <div class="error-message">{{ errors.username }}</div>
      <div class="form-field">
        <span class="fas fa-key"></span>
        <Field
          type="password"
          name="password"
          placeholder="Пароль"
          autocomplete="off"
          v-model="password"
        />
      </div>
      <div class="error-message">{{ errors.password }}</div>
      <div class="error-message">{{ authStore.errors }}</div>
      <div class="buttons">
        <button
          id="button"
          :class="{
            onclic: authStore.isClicked,
            validate: authStore.isValidated,
          }"
          type="submit"
        ></button>
      </div>
    </Form>
    <div class="version">version 3.0.0</div>
  </div>
</template>
<script setup>
import { ref, computed } from "vue";
import { schemaRules } from "@/plugins/vee-validate";
import store from "@/store";

const username = ref("");
const password = ref("");

const authStore = computed(() => store.state.authStore);

const loginHandler = async (username, password) => {
  try {
    await store.dispatch("login", { username, password });
  } catch (error) {
    console.log(error);
  }
};
</script>
<style scoped>
@import "../../styles/authorization/login.css";
@import "~@fortawesome/fontawesome-free/css/all.min.css";
@import "../../styles/authorization/animate-button.css";
</style>
