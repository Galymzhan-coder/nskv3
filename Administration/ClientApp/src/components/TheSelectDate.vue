<template>
  <div class="date-content">
    <div class="date-header" @click="toggleDateModal">
      <h2 class="selectArticleOfDate">Выбрать статьи по дате</h2>
      <div class="additional-btn">
        <a class="down-open-click">
          <svg
            v-if="isShowDateModal"
            class="w-4 h-4 text-gray-800 dark:text-white"
            aria-hidden="true"
            xmlns="http://www.w3.org/2000/svg"
            fill="none"
            viewBox="0 0 14 8"
          >
            <path
              stroke="currentColor"
              stroke-linecap="round"
              stroke-linejoin="round"
              stroke-width="2"
              d="M13 7 7.674 1.3a.91.91 0 0 0-1.348 0L1 7"
            />
          </svg>
          <svg
            v-else
            class="w-4 h-4 text-gray-800 dark:text-white"
            aria-hidden="true"
            xmlns="http://www.w3.org/2000/svg"
            fill="none"
            viewBox="0 0 14 8"
          >
            <path
              stroke="currentColor"
              stroke-linecap="round"
              stroke-linejoin="round"
              stroke-width="2"
              d="m1 1 5.326 5.7a.909.909 0 0 0 1.348 0L13 1"
            />
          </svg>
        </a>
      </div>
    </div>
    <transition name="slide">
      <div class="search-date" v-if="isShowDateModal">
        <div class="begin-date col-md-3">
          <label>C</label>
          <VueDatePicker
            v-model="beginDate"
            placeholder="yyyy-mm-dd"
            :format="dateFormat"
            :clearable="false"
          ></VueDatePicker>
        </div>

        <div class="end-date col-md-3">
          <label>По</label>
          <VueDatePicker
            v-model="endDate"
            placeholder="yyyy-mm-dd"
            :format="dateFormat"
            :clearable="false"
          ></VueDatePicker>
        </div>
        <div class="search-btn col-md-3">
          <label>&nbsp;</label>
          <button class="btn" @click="searchByDate">Найти</button>
        </div>
      </div>
    </transition>
  </div>
</template>

<script setup>
import VueDatePicker from "@vuepic/vue-datepicker";
import "@vuepic/vue-datepicker/dist/main.css";
import { ref } from "vue";
import { format } from 'date-fns'

const beginDate = format(ref(new Date()).value, 'yyyy-MM-dd');
const endDate = format(ref(new Date()).value, 'yyyy-MM-dd');
const dateFormat = ref("yyyy-MM-dd");
let isShowDateModal = ref(false);

const toggleDateModal = () => {
  isShowDateModal.value = !isShowDateModal.value;
};

const searchByDate = () => {
  if(beginDate == '' || endDate == '') {
    return 
  }
};
</script>

<style scoped>
.date-content {
  position: relative;
  width: 100%;
  margin-bottom: 20px;
}
.date-header {
  display: flex;
  margin-left: 20px;
  background-color: beige;
  width: 1150px;
  height: 30px;
}
.search-date {
  display: flex;
  margin-left: 20px;
  width: 1150px;
}
.dp__action_select {
  color: black;
}
.dp__button {
  display: none;
}
.dp__action_cancel {
  background-color: white !important;
}
.dp__action_button {
  line-height: 0px;
  background-color: cornflowerblue !important;
}
.additional-btn {
  margin-left: auto;
}

.search-date {
  background-color: beige;
}

.begin-date,
.end-date {
  width: 200px;
  padding-right: 20px;
}
.selectArticleOfDate {
  font-size: 18px;
}

.search-btn {
  display: grid;
  place-items: center;
  height: 10px; /* Высота div */
}
.btn {
  background-color: lightskyblue;
  width: 100px;
  height: 30px;
}
.btn:hover {
  background-color: white;
}
</style>
