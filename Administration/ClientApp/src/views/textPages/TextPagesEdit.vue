<template>
  <div class="modal">
    <div class="modal-content p-4 border">
      <h2>Редактировать запись</h2>
      <form @submit.prevent="saveItem">
        <label>Наименование:</label>
        <input v-model="formData.name" type="text" />

        <label>ЧПУ:</label>
        <input v-model="formData.name" type="text" />

        <label>Активность:</label>
        <input v-model="formData.active" type="checkbox" />

        <button type="submit">Сохранить</button>
        <button @click="cancel">Отмена</button>
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref, defineProps, defineEmits } from 'vue';

const props = defineProps(['item']);
const emit = defineEmits(['save', 'cancel']);

const formData = ref({ ...props.item });

function saveItem() {
  emit('save', formData.value);
}

function cancel() {
  emit('cancel');
}
</script>

<style>
/* Стили для модального окна (пример) */
.modal {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.5);
  display: flex;
  justify-content: center;
  align-items: center;
}

.modal-content {
  background-color: white;
  padding: 20px;
}
</style>
