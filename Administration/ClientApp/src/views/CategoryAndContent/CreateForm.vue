<template>
    <TheHeadTitle :title="createTitle" />
    <p>Abs</p>
</template>

<script setup>
import TheHeadTitle from "@/components/TheHeadTitle.vue";
import { ref } from 'vue'

const createTitle = ref('Создание статьи')


</script>

<style>
</style>