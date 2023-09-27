import { createStore } from 'vuex'
import { article } from './article'
import { authStore } from './authorization'

/* Модуль авторизации */


const store = createStore({
  modules: {
    authStore: authStore,
    articleStore: article
  },
})

export default store;
