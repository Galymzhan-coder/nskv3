<template>
  <div class="btn-create">
    <button class="create-btn" @click="goToNextPage">{{ createTitle }}</button>
  </div>
</template>

<script setup>
import router from "@/router";
import { ref } from "vue";

const createTitle = ref("Создать статью");

const goToNextPage = () => {
  router.push({ name: 'CreateForm' })
}

</script>
<style>
.btn-create {
  margin-left: 20px;
  margin-bottom: 20px;
}
.create-btn {
  background-color: lightgreen;
  width: 130px;
  color: black;
  font-weight: 500;
}
</style>