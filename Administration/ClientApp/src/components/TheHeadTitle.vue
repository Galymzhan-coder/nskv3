<template>
  <div class="title">
    <span></span>
    <h1 class="headTitle">{{ props.title }}</h1>
  </div>
</template>

<script setup>
import { defineProps } from "vue";

const props = defineProps(["title"]);
</script>
<style scoped>
.title {
  font-size: 24px;
  font-weight: 400;
  margin: 0px 0 20px 20px;
}
.headTitle {
  font-family: Open Sans;
  line-height: 43px;
  padding-top: 20px;
}
</style>
