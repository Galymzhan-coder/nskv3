import store from "@/store";
//import { h, resolveComponent } from 'vue'
import { createRouter, createWebHashHistory } from "vue-router";

import category from '../views/category/Category';

import textPages from '../views/textPages/TextPages';
import categoryEdit from '../views/category/CategoryEdit';

const routes = [
  {
    path: "/",
    name: "Home",
    redirect: "/auth",
  },
  {
    path: "/auth",
    name: "Auth",
    component: () => import("@/views/authorization/Login.vue"),
  },
  {
    path: "/dashboard",
    name: "Dashboard",
    meta: { requiresAuth: true },
    component: () => import("@/views/master/dashboard_new.vue"),
    children: [
      {
        path: "/articles",
        name: "Articles",
        component: () => import("@/views/CategoryAndContent/Articles.vue"),
        children: [
          {
            path: "/create",
            name: "CreateForm",
            component: () =>
              import("@/views/CategoryAndContent/CreateForm.vue"),
          },
        ],
      },
      {
        name: 'Category',
        path: '/Category',
        component: category,
      },
      {
        name: 'TextPages',
        path: '/TextPages',
        component: textPages,
      },
      {
        name: 'categoryEdit',
        path: '/categoryEdit/:id',
        component: categoryEdit,
      },
    ],
  },
];

let base = "admin.vue/";

const router = createRouter({
  history: createWebHashHistory(),
  base,
  routes,
  linkActiveClass: "active",
});

/* Проверка верификация */

router.beforeEach(async (to, from, next) => {
  if (to.matched.some((route) => route.meta.requiresAuth)) {
    if (store.state.authStore.token) {
      next();
    } else {
      next({ name: "Auth" });
    }
  } else {
    next();
  }
});

export default router;
