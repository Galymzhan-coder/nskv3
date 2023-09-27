<template>
  <div class="content">
    <TheHeadTitle :title="articleTitle" />
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
        <div class="search-date" v-if="!isShowDateModal">
          <div class="begin-date col-md-3">
            <label>C</label>
            <VueDatePicker
              v-model="articleStore.beginDate"
              placeholder="yyyy-mm-dd"
              :format="articleStore.dateFormat"
              :clearable="false"
            ></VueDatePicker>
          </div>

          <div class="end-date col-md-3">
            <label>По</label>
            <VueDatePicker
              v-model="articleStore.endDate"
              placeholder="yyyy-mm-dd"
              :format="articleStore.dateFormat"
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
    <TheCreateButton />
    <div class="article">
      <div class="article-content">
        <div
          class="relative shadow-md sm:rounded-lg border-none w-[calc(100%-7%)]"
        >
          <table
            class="w-[100%] text-sm text-left text-gray-500 dark:text-gray-400"
          >
            <thead class="text-xs text-gray-700 uppercase bg-gray-100 border-b">
              <tr class="border-b">
                <th scope="col" class="px-6 py-3">#</th>
                <th scope="col" class="px-6 py-3">Заголовок</th>
                <th scope="col" class="px-6 py-3">Дата публикации</th>
                <th scope="col" class="px-6 py-3">Категории</th>
                <th scope="col" class="px-6 py-3">ЧПУ</th>
                <th scope="col" class="px-6 py-3">Видимость</th>
                <th scope="col" class="px-6 py-3">Действия</th>
              </tr>
              <tr>
                <td class="px-6 py-4">&nbsp;</td>
                <td class="px-6 py-4">
                  <div class="group">
                    <input
                      type="text"
                      class="inputByName"
                      v-model="articleStore.searchByName"
                      placeholder="Search by Title"
                    />
                  </div>
                </td>
                <td class="px-6 py-4">
                  <input
                    type="text"
                    v-model="articleStore.searchByPublishDate"
                  />
                </td>
                <td class="px-6 py-4">
                  <select
                    class="w-[100px]"
                    v-model="articleStore.searchByCategory"
                  >
                    <option></option>
                    <option>2023</option>
                    <option>2021</option>
                    <option>2022</option>
                    <option>2020</option>
                  </select>
                </td>
                <td class="px-6 py-4">&nbsp;</td>
                <td class="px-6 py-4">&nbsp;</td>
                <td class="px-6 py-4">&nbsp;</td>
              </tr>
            </thead>
            <tbody>
              <tr
                class="bg-white border-b dark:bg-gray-800 dark:border-gray-700"
                v-for="article in filteredArticles"
                :key="article.id"
              >
                <td class="px-6 py-4">{{ article.id }}</td>
                <td class="px-6 py-4">{{ article.title }}</td>
                <td class="px-6 py-4">{{ article.publish_date }}</td>
                <td class="px-6 py-4">{{ article.category }}</td>
                <td class="px-6 py-4">{{ article.sefname }}</td>
                <td class="px-6 py-4">{{ article.active }}</td>
                <td class="px-6 py-4">
                  <a
                    href="#"
                    class="font-medium text-blue-600 dark:text-blue-500 hover:underline"
                    >Edit</a
                  >
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import TheHeadTitle from "@/components/TheHeadTitle.vue";
import TheCreateButton from "@/components/TheCreateButton.vue";
import VueDatePicker from "@vuepic/vue-datepicker";
import "@vuepic/vue-datepicker/dist/main.css";
import { ref, computed } from "vue";
import store from "@/store";

const articleTitle = "Статьи";
const articleStore = ref(computed(() => store.state.articleStore));
let isShowDateModal = ref(false);

const toggleDateModal = () => {
  isShowDateModal.value = !isShowDateModal.value;
};

const filteredArticles = computed(() => {
  let searchByName = articleStore.value.searchByName.trim();
  let searchByPublishDate = articleStore.value.searchByPublishDate.trim();
  let searchByCategory = articleStore.value.searchByCategory.trim();

  let articles = articleStore.value.articles;

  // Фильтрация по названию
  let filteredByName = articles.filter((article) =>
    article.title.toLowerCase().includes(searchByName.toLowerCase())
  );
  // Фильтрация по дате публикации
  if (searchByPublishDate === "") {
    return filteredByName;
  }

  let filteredByDate = filteredByName.filter((article) =>
    article.publish_date.includes(searchByPublishDate)
  );

  if (searchByCategory === "") {
    return filteredByDate; // Если категория не выбрана, возвращаем результат фильтрации по дате
  }

  return filteredByDate.filter(
    (article) => article.category === searchByCategory
  );
});
</script>

<style scoped>
.content {
  position: relative;
  width: 97%;
  margin-left: 20px;
}
.article-content {
  margin-left: 20px;
}

select {
  border: 2px solid blue;
}
.date-content {
  position: static;
  width: 93%;
  margin-bottom: 20px;
}
.date-header {
  display: flex;
  margin-left: 20px;
  background-color: beige;
  height: 30px;
}
.search-date {
  display: flex;
  margin-left: 20px;
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
.inputByName {
  width: 250px;
  height: 30px;
  background: none;
  display: block;
  border: none;
  border-bottom: 3px solid black;
}

</style>
