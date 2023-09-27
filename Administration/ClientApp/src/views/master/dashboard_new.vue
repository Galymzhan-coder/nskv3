<template>
  <div class="w-full h-full">
    <!-- Side bar -->

    <div
      class="fixed w-[300px] h-[calc(100vh-25px)] text-white top-0 left-0 z-10"
      v-show="showSide"
    >
      <div
        class="h-[50px] bg-gray-900 flex justify-start items-center w-[280px]"
      >
        <div class="px-[20px]">
          <h3 class="font-bold text-xl">Admin dashbord</h3>
        </div>
      </div>
      <div class="h-[calc(h-auto-50px)] bg-gray-800 py-[20px] w-[280px]">
        <div class="flex flex-col justify-between h-full space-y-[10px]">
          <div class="flex flex-col justify-between">
            <MenuTree :menuItems="menuItems" />
          </div>

          <!--<img :src="mySvgIcon" alt="MySvgIcon" />-->

          <div class="h-[50px]">
            <div>
              <router-link
                to="/settings"
                class="inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  stroke-width="1.5"
                  stroke="currentColor"
                  class="w-6 h-6"
                >
                  <path
                    stroke-linecap="round"
                    stroke-linejoin="round"
                    d="M12 9.75v6.75m0 0l-3-3m3 3l3-3m-8.25 6a4.5 4.5 0 01-1.41-8.775 5.25 5.25 0 0110.233-2.33 3 3 0 013.758 3.848A3.752 3.752 0 0118 19.5H6.75z"
                  />
                </svg>
                Settings
              </router-link>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="h-full w-full">
      <div
        class="top-0 fixed h-[50px] bg-gray-100 flex items-center shadow-sm px-[20px] py-[10px] border-b z-10"
        :class="{
          'w-[calc(100%-280px)] left-[280px]': showSide,
          'w-full left-0': !showSide,
        }"
      >
        <!-- Hamburger menu -->
        <div class="cursor-pointer w-[30px]" @click="toogleSideBar">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            fill="none"
            viewBox="0 0 24 24"
            stroke-width="1.5"
            stroke="currentColor"
            class="w-6 h-6"
          >
            <path
              stroke-linecap="round"
              stroke-linejoin="round"
              d="M3.75 6.75h16.5M3.75 12h16.5m-16.5 5.25h16.5"
            />
          </svg>
        </div>
        <!-- Search bar -->
        <div class="w-[calc(100%-30px)] flex">
          <!-- Search bar -->
          <div class="w-[calc(100%-200px)] flex justify-center">
            <form class="flex items-center w-[500px]">
              <label for="voice-search" class="sr-only">Search</label>
              <div class="relative w-full">
                <div
                  class="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none"
                >
                  <svg
                    class="absolute text-slate-400 h-5 w-5"
                    viewBox="0 0 20 20"
                    fill="currentColor"
                  >
                    <path
                      fill-rule="evenodd"
                      d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z"
                      clip-rule="evenodd"
                    />
                  </svg>
                </div>
                <input
                  type="text"
                  id="voice-search"
                  class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  placeholder="Search Mockups, Logos"
                />
                <router-link
                  to="/"
                  class="flex absolute inset-y-0 right-0 items-center pr-3"
                >
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                    stroke-width="1.5"
                    stroke="currentColor"
                    class="w-6 h-6"
                  >
                    <path
                      stroke-linecap="round"
                      stroke-linejoin="round"
                      d="M12 18.75a6 6 0 006-6v-1.5m-6 7.5a6 6 0 01-6-6v-1.5m6 7.5v3.75m-3.75 0h7.5M12 15.75a3 3 0 01-3-3V4.5a3 3 0 116 0v8.25a3 3 0 01-3 3z"
                    />
                  </svg>
                </router-link>
              </div>
            </form>
          </div>
          <!-- User login-->
          <div class="w-[200px]">
            <div
              class="flex items-center justify-start space-x-4"
              @click="toogleDrop"
            >
              <img
                class="w-10 h-10 rounded-full border-2 border-gray-50"
                src="https://yt3.ggpht.com/TIQQYIzlVLDqthkfjBefvxUaca6HFJVgHeN6Y63iND-pmSf0PJ5GzDh0HnuOyOy1Vrlc2BQp4g=s48-c-k-c0x00ffffff-no-rj"
              />
              <div class="font-semibold dark:text-white text-left">
                <div>Konilzhai, Dev</div>
                <div class="text-xs text-gray-500 dark:text-gray-400">
                  Admin
                </div>
              </div>
            </div>
            <!-- Drop down -->
            <div
              v-show="showDropDown"
              class="absolute right-[10px] z-10 mt-2 w-56 origin-top-right rounded-md bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none"
            >
              <div class="py-1 text-left" role="none">
                <a
                  href="#"
                  class="text-gray-700 block px-4 py-2 text-sm"
                  role="menuitem"
                  tabindex="-1"
                  id="menu-item-0"
                  >Account settings</a
                >
                <a
                  href="#"
                  class="text-gray-700 block px-4 py-2 text-sm"
                  role="menuitem"
                  tabindex="-1"
                  id="menu-item-1"
                  >Support</a
                >
                <a
                  href="#"
                  class="text-gray-700 block px-4 py-2 text-sm"
                  role="menuitem"
                  tabindex="-1"
                  id="menu-item-2"
                  >License</a
                >
                <form method="POST" action="#" role="none">
                  <button
                    type="submit"
                    class="text-gray-700 block w-full px-4 py-2 text-left text-sm"
                    role="menuitem"
                    tabindex="-1"
                    id="menu-item-3"
                  >
                    Sign out
                  </button>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="h-full bg-gray-50 p-[20px] top-0">
        <div
          class="absolute border border-gray-300 p-[20px] h-full border-none top-[50px]"
          :class="{
            'w-[calc(100%-280px)] left-[280px]': showSide,
            'w-full left-0': !showSide,
          }"
        >
          <transition name="page" mode="out-in">
            <router-view></router-view>
          </transition>
        </div>
      </div>
      <!-- Main -->
    </div>
  </div>
</template>

<script>
import MenuTree from "./MenuTree.vue";
import MySvgIcon from "@/assets/images/insurance-svgrepo-com.svg";

export default {
  components: {
    MenuTree,
  },
  data() {
    return {
      showDropDown: false,
      showSide: true,
      mySvgIcon: MySvgIcon,
      menuItems: [
        {
          id: 1,
          label: "Home",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/home",
          svg:
            '<svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">' +
            '<path stroke-linecap="round" stroke-linejoin="round" d="M2.25 12l8.954-8.955c.44-.439 1.152-.439 1.591 0L21.75 12M4.5 9.75v10.125c0 .621.504 1.125 1.125 1.125H9.75v-4.875c0-.621.504-1.125 1.125-1.125h2.25c.621 0 1.125.504 1.125 1.125V21h4.125c.621 0 1.125-.504 1.125-1.125V9.75M8.25 21h8.25" /></svg>',
        },
        {
          id: 2,
          label: "Category and content",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-500"  width="24" height="24" viewBox="0 0 24 24" stroke-width="1.9" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  
                      <path stroke="none" d="M0 0h24v24H0z"/>  
                      <line x1="1" y1="6" x2="1" y2="6" /><line x1="5" y1="6" x2="19" y2="6" />
                      <line x1="5" y1="10" x2="5" y2="10" /><line x1="10" y1="10" x2="19" y2="10" />
                      <line x1="10" y1="14" x2="10" y2="14" /><line x1="15" y1="14" x2="19" y2="14" />
                      <line x1="5" y1="18" x2="5" y2="18" /><line x1="10" y1="18" x2="19" y2="18" />
                      </svg>`,
          children: [
            {
              id: 3,
              label: "Category",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/Category",
              svg: `<svg class="h-5 w-5 text-white-900"  width="21" height="21" viewBox="0 0 21 21" stroke-width="1.9" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  
                      <path stroke="none" d="M0 0h24v24H0z"/>  
                      <line x1="1" y1="6" x2="1" y2="6" /><line x1="5" y1="6" x2="19" y2="6" />
                      <line x1="5" y1="10" x2="5" y2="10" /><line x1="10" y1="10" x2="19" y2="10" />
                      <line x1="10" y1="14" x2="10" y2="14" /><line x1="15" y1="14" x2="19" y2="14" />
                      <line x1="5" y1="18" x2="5" y2="18" /><line x1="10" y1="18" x2="19" y2="18" />
                      </svg>`,
            },
            {
              id: 4,
              label: "Articles",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/articles",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M16 6h3a1 1 0 0 1 1 1v11a2 2 0 0 1 -4 0v-13a1 1 0 0 0 -1 -1h-10a1 1 0 0 0 -1 1v12a3 3 0 0 0 3 3h11" />  <line x1="8" y1="8" x2="12" y2="8" />  <line x1="8" y1="12" x2="12" y2="12" />  <line x1="8" y1="16" x2="12" y2="16" /></svg>`,
            },
            {
              id: 5,
              label: "Text pages",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M19 20H5a2 2 0 01-2-2V6a2 2 0 012-2h10a2 2 0 012 2v1m2 13a2 2 0 01-2-2V7m2 13a2 2 0 002-2V9a2 2 0 00-2-2h-2m-4-3H9M7 16h6M7 8h6v4H7V8z"/>
                      </svg>`,
            },
            {
              id: 6,
              label: "Top managers",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-4 w-4 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z"/>
                      </svg>`,
            },
          ],
        },
        {
          id: 7,
          label: "Blog",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">
                  <polygon points="12 2 2 7 12 12 22 7 12 2" />
                  <polyline points="2 17 12 22 22 17" />
                  <polyline points="2 12 12 17 22 12" />
                  </svg>`,

          children: [
            {
              id: 8,
              label: "Blog entries",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
                      <path stroke="none" d="M0 0h24v24H0z"/>
                      <rect x="4" y="4" width="6" height="6" rx="1" />
                      <rect x="14" y="4" width="6" height="6" rx="1" />
                      <rect x="4" y="14" width="6" height="6" rx="1" />
                      <rect x="14" y="14" width="6" height="6" rx="1" />
                      </svg>`,
            },
            {
              id: 9,
              label: "Category",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">
                      <line x1="21" y1="10" x2="3" y2="10" />
                      <line x1="21" y1="6" x2="3" y2="6" />
                      <line x1="21" y1="14" x2="3" y2="14" />
                      <line x1="21" y1="18" x2="3" y2="18" />
                      </svg>`,
            },
          ],
        },
        {
          id: 10,
          label: "Question and Answer",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">
                  <polygon points="12 2 2 7 12 12 22 7 12 2" />
                  <polyline points="2 17 12 22 22 17" />
                  <polyline points="2 12 12 17 22 12" />
                  </svg>`,
          children: [
            {
              id: 11,
              label: "Question",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="4" y="4" width="6" height="6" rx="1" />  <rect x="14" y="4" width="6" height="6" rx="1" />  <rect x="4" y="14" width="6" height="6" rx="1" />  <rect x="14" y="14" width="6" height="6" rx="1" /></svg>`,
            },
            {
              id: 12,
              label: "Category",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <line x1="21" y1="10" x2="3" y2="10" />  <line x1="21" y1="6" x2="3" y2="6" />  <line x1="21" y1="14" x2="3" y2="14" />  <line x1="21" y1="18" x2="3" y2="18" /></svg>`,
            },
          ],
        },
        {
          id: 13,
          label: "Contacts",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M9 5H7a2 2 0 0 0 -2 2v12a2 2 0 0 0 2 2h10a2 2 0 0 0 2 -2V7a2 2 0 0 0 -2 -2h-2" />  <rect x="9" y="3" width="6" height="4" rx="2" />  <line x1="9" y1="12" x2="9.01" y2="12" />  <line x1="13" y1="12" x2="15" y2="12" />  <line x1="9" y1="16" x2="9.01" y2="16" />  <line x1="13" y1="16" x2="15" y2="16" /></svg>`,
          children: [
            {
              id: 14,
              label: "Offices",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="4" y="4" width="6" height="6" rx="1" />  <rect x="14" y="4" width="6" height="6" rx="1" />  <rect x="4" y="14" width="6" height="6" rx="1" />  <rect x="14" y="14" width="6" height="6" rx="1" /></svg>`,
            },
            {
              id: 15,
              label: "Cities",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <line x1="3" y1="21" x2="21" y2="21" />  <path d="M5 21v-14l8 -4v18" />  <path d="M19 21v-10l-6 -4" />  <line x1="9" y1="9" x2="9" y2="9.01" />  <line x1="9" y1="12" x2="9" y2="12.01" />  <line x1="9" y1="15" x2="9" y2="15.01" />  <line x1="9" y1="18" x2="9" y2="18.01" /></svg>`,
            },
          ],
        },
        {
          id: 16,
          label: "Products",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <polyline points="12 3 20 7.5 20 16.5 12 21 4 16.5 4 7.5 12 3" />  <line x1="12" y1="12" x2="20" y2="7.5" />  <line x1="12" y1="12" x2="12" y2="21" />  <line x1="12" y1="12" x2="4" y2="7.5" />  <line x1="16" y1="5.25" x2="8" y2="9.75" /></svg>`,
          children: [
            {
              id: 17,
              label: "Products",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="4" y="4" width="6" height="6" rx="1" />  <rect x="14" y="4" width="6" height="6" rx="1" />  <rect x="4" y="14" width="6" height="6" rx="1" />  <rect x="14" y="14" width="6" height="6" rx="1" /></svg>`,
            },
            {
              id: 18,
              label: "Promotions",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="3" y="8" width="18" height="4" rx="1" />  <line x1="12" y1="8" x2="12" y2="21" />  <path d="M19 12v7a2 2 0 0 1 -2 2h-10a2 2 0 0 1 -2 -2v-7" />  <path d="M7.5 8a2.5 2.5 0 0 1 0 -5a4.8 8 0 0 1 4.5 5a4.8 8 0 0 1 4.5 -5a2.5 2.5 0 0 1 0 5" /></svg>`,
            },
            {
              id: 19,
              label: "Category",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <line x1="21" y1="10" x2="3" y2="10" />  <line x1="21" y1="6" x2="3" y2="6" />  <line x1="21" y1="14" x2="3" y2="14" />  <line x1="21" y1="18" x2="3" y2="18" /></svg>`,
            },
            {
              id: 20,
              label: "Calculator",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="4" y="3" width="16" height="18" rx="2" />  <rect x="8" y="7" width="8" height="3" rx="1" />  <line x1="8" y1="14" x2="8" y2="14.01" />  <line x1="12" y1="14" x2="12" y2="14.01" />  <line x1="16" y1="14" x2="16" y2="14.01" />  <line x1="8" y1="17" x2="8" y2="17.01" />  <line x1="12" y1="17" x2="12" y2="17.01" />  <line x1="16" y1="17" x2="16" y2="17.01" /></svg>`,
            },
            {
              id: 21,
              label: "Promo",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
  <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M11 5.882V19.24a1.76 1.76 0 01-3.417.592l-2.147-6.15M18 13a3 3 0 100-6M5.436 13.683A4.001 4.001 0 017 6h1.832c4.1 0 7.625-1.234 9.168-3v14c-1.543-1.766-5.067-3-9.168-3H7a3.988 3.988 0 01-1.564-.317z"/>
</svg>`,
            },
            {
              id: 22,
              label: "Hints",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="12" cy="12" r="9" />  <line x1="12" y1="8" x2="12" y2="12" />  <line x1="12" y1="16" x2="12.01" y2="16" /></svg>`,
            },
            {
              id: 23,
              label: "Cities for OGPO",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <line x1="3" y1="21" x2="21" y2="21" />  <path d="M5 21v-14l8 -4v18" />  <path d="M19 21v-10l-6 -4" />  <line x1="9" y1="9" x2="9" y2="9.01" />  <line x1="9" y1="12" x2="9" y2="12.01" />  <line x1="9" y1="15" x2="9" y2="15.01" />  <line x1="9" y1="18" x2="9" y2="18.01" /></svg>`,
            },
            {
              id: 24,
              label: "Calculation steps",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="3" y="4" width="18" height="16" rx="2" />  <line x1="7" y1="8" x2="7" y2="8.01" />  <line x1="12" y1="8" x2="12" y2="8.01" />  <line x1="17" y1="8" x2="17" y2="8.01" />  <line x1="7" y1="12" x2="7" y2="12.01" />  <line x1="12" y1="12" x2="12" y2="12.01" />  <line x1="17" y1="12" x2="17" y2="12.01" />  <line x1="7" y1="16" x2="17" y2="16" /></svg>`,
            },
            {
              id: 25,
              label: "Advantages",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M4 13a8 8 0 0 1 7 7a6 6 0 0 0 3 -5a9 9 0 0 0 6 -8a3 3 0 0 0 -3 -3a9 9 0 0 0 -8 6a6 6 0 0 0 -5 3" />  <path d="M7 14a6 6 0 0 0 -3 6a6 6 0 0 0 6 -3" />  <circle cx="15" cy="9" r="1"  /></svg>`,
            },
            {
              id: 26,
              label: "Risks",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <polyline points="3 17 9 11 13 15 21 7" />  <polyline points="14 7 21 7 21 14" /></svg>`,
            },
            {
              id: 27,
              label: "Rules",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11" />  <line x1="9" y1="7" x2="13" y2="7" />  <line x1="9" y1="11" x2="13" y2="11" /></svg>`,
            },
          ],
        },
        {
          id: 28,
          label: "Insured event",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M9 12l2 2l4 -4" />  <path d="M12 3a12 12 0 0 0 8.5 3a12 12 0 0 1 -8.5 15a12 12 0 0 1 -8.5 -15a12 12 0 0 0 8.5 -3" /></svg>`,
          children: [
            {
              id: 29,
              label: "Insured events",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M9 12l2 2l4 -4" />  <path d="M12 3a12 12 0 0 0 8.5 3a12 12 0 0 1 -8.5 15a12 12 0 0 1 -8.5 -15a12 12 0 0 0 8.5 -3" /></svg>`,
            },
            {
              id: 30,
              label: "Event types",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <line x1="21" y1="10" x2="3" y2="10" />  <line x1="21" y1="6" x2="3" y2="6" />  <line x1="21" y1="14" x2="3" y2="14" />  <line x1="21" y1="18" x2="3" y2="18" /></svg>`,
            },
            {
              id: 31,
              label: "Evacuator calling",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="4" y="4" width="6" height="6" rx="1" />  <rect x="14" y="4" width="6" height="6" rx="1" />  <rect x="4" y="14" width="6" height="6" rx="1" />  <rect x="14" y="14" width="6" height="6" rx="1" /></svg>`,
            },
            {
              id: 32,
              label: "Insured events App",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <g transform="rotate(27 12 12)">  <rect x="7" y="4" width="10" height="16" rx="1" />  <line x1="11" y1="5" x2="13" y2="5" />  <line x1="12" y1="17" x2="12" y2="17.01" />  </g>  <path d="M6 4l-2 1v2.5l-2 1v2.5" />  <path d="M22 13v2.5l-2 1v2.5l-2 1" /></svg>`,
            },
          ],
        },
        {
          id: 33,
          label: "Agents",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="9" cy="7" r="4" />  <path d="M3 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2" />  <path d="M16 3.13a4 4 0 0 1 0 7.75" />  <path d="M21 21v-2a4 4 0 0 0 -3 -3.85" /></svg>`,
          children: [
            {
              id: 34,
              label: "Agent profiles",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="9" cy="7" r="4" />  <path d="M3 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2" />  <path d="M16 3.13a4 4 0 0 1 0 7.75" />  <path d="M21 21v-2a4 4 0 0 0 -3 -3.85" /></svg>`,
            },
          ],
        },
        {
          id: 35,
          label: "Modules",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <path d="M21 16V8a2 2 0 0 0-1-1.73l-7-4a2 2 0 0 0-2 0l-7 4A2 2 0 0 0 3 8v8a2 2 0 0 0 1 1.73l7 4a2 2 0 0 0 2 0l7-4A2 2 0 0 0 21 16z" />  <polyline points="7.5 4.21 12 6.81 16.5 4.21" />  <polyline points="7.5 19.79 7.5 14.6 3 12" />  <polyline points="21 12 16.5 14.6 16.5 19.79" />  <polyline points="3.27 6.96 12 12.01 20.73 6.96" />  <line x1="12" y1="22.08" x2="12" y2="12" /></svg>`,
          children: [
            {
              id: 36,
              label: "Reviews",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M14 3v4a1 1 0 0 0 1 1h4" />  <path d="M17 21h-10a2 2 0 0 1 -2 -2v-14a2 2 0 0 1 2 -2h7l5 5v11a2 2 0 0 1 -2 2z" />  <line x1="9" y1="7" x2="10" y2="7" />  <line x1="9" y1="13" x2="15" y2="13" />  <line x1="13" y1="17" x2="15" y2="17" /></svg>`,
            },
            {
              id: 37,
              label: "Gallery",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <rect x="3" y="3" width="18" height="18" rx="2" ry="2" />  <circle cx="8.5" cy="8.5" r="1.5" />  <polyline points="21 15 16 10 5 21" /></svg>`,
            },
            {
              id: 38,
              label: "Slider",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="33" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
                  <polyline points="16 18 22 12 16 6" />
                  <polyline points="8 6 2 12 8 18" />
                      <rect x="0" y="4" width="24" height="16" rx="2" />
                      </svg>`,
            },
            {
              id: 39,
              label: "Video-reviews",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <polygon points="23 7 16 12 23 17 23 7" />  <rect x="1" y="5" width="15" height="14" rx="2" ry="2" /></svg>`,
            },
            {
              id: 40,
              label: "Menu",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M4 21v-13a3 3 0 0 1 3 -3h10a3 3 0 0 1 3 3v6a3 3 0 0 1 -3 3h-9l-4 4" />  <line x1="8" y1="9" x2="16" y2="9" />  <line x1="8" y1="13" x2="14" y2="13" /></svg>`,
            },
          ],
        },
        {
          id: 41,
          label: "Settings",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <circle cx="12" cy="12" r="3" />  <path d="M19.4 15a1.65 1.65 0 0 0 .33 1.82l.06.06a2 2 0 0 1 0 2.83 2 2 0 0 1-2.83 0l-.06-.06a1.65 1.65 0 0 0-1.82-.33 1.65 1.65 0 0 0-1 1.51V21a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-.09A1.65 1.65 0 0 0 9 19.4a1.65 1.65 0 0 0-1.82.33l-.06.06a2 2 0 0 1-2.83 0 2 2 0 0 1 0-2.83l.06-.06a1.65 1.65 0 0 0 .33-1.82 1.65 1.65 0 0 0-1.51-1H3a2 2 0 0 1-2-2 2 2 0 0 1 2-2h.09A1.65 1.65 0 0 0 4.6 9a1.65 1.65 0 0 0-.33-1.82l-.06-.06a2 2 0 0 1 0-2.83 2 2 0 0 1 2.83 0l.06.06a1.65 1.65 0 0 0 1.82.33H9a1.65 1.65 0 0 0 1-1.51V3a2 2 0 0 1 2-2 2 2 0 0 1 2 2v.09a1.65 1.65 0 0 0 1 1.51 1.65 1.65 0 0 0 1.82-.33l.06-.06a2 2 0 0 1 2.83 0 2 2 0 0 1 0 2.83l-.06.06a1.65 1.65 0 0 0-.33 1.82V9a1.65 1.65 0 0 0 1.51 1H21a2 2 0 0 1 2 2 2 2 0 0 1-2 2h-.09a1.65 1.65 0 0 0-1.51 1z" /></svg>`,
          children: [
            {
              id: 42,
              label: "System settings",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <path d="M10.325 4.317c.426-1.756 2.924-1.756 3.35 0a1.724 1.724 0 0 0 2.573 1.066c1.543-.94 3.31.826 2.37 2.37a1.724 1.724 0 0 0 1.065 2.572c1.756.426 1.756 2.924 0 3.35a1.724 1.724 0 0 0 -1.066 2.573c.94 1.543-.826 3.31-2.37 2.37a1.724 1.724 0 0 0 -2.572 1.065c-.426 1.756-2.924 1.756-3.35 0a1.724 1.724 0 0 0 -2.573 -1.066c-1.543.94-3.31-.826-2.37-2.37a1.724 1.724 0 0 0 -1.065 -2.572c-1.756-.426-1.756-2.924 0-3.35a1.724 1.724 0 0 0 1.066 -2.573c-.94-1.543.826-3.31 2.37-2.37.996.608 2.296.07 2.572-1.065z" />  <circle cx="12" cy="12" r="3" /></svg>`,
            },
            {
              id: 43,
              label: "Languages",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="12" cy="12" r="9" />  <line x1="3.6" y1="9" x2="20.4" y2="9" />  <line x1="3.6" y1="15" x2="20.4" y2="15" />  <path d="M11.5 3a17 17 0 0 0 0 18" />  <path d="M12.5 3a17 17 0 0 1 0 18" /></svg>`,
            },
            {
              id: 44,
              label: "Translations",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                        <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 5h12M9 3v2m1.048 9.5A18.022 18.022 0 016.412 9m6.088 9h7M11 21l5-10 5 10M12.751 5C11.783 10.77 8.07 15.61 3 18.129"/>
                      </svg>`,
            },
            {
              id: 45,
              label: "Logs",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24">
                        <rect x="4" y="6" width="19" height="17" rx="3" stroke-width="2" stroke="currentColor" fill="none" />
                        <path d="M6 14l2-2 4 4 6-6 2 2-8 8z" stroke-width="2" stroke="currentColor" fill="none" />
                      </svg>`,
            },
            {
              id: 46,
              label: "Action Logs",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24">
                        <rect x="3" y="5" width="18" height="14" rx="2" stroke-width="2" stroke="currentColor" fill="none" />
                        <path d="M6 15h12M6 12h12M6 9h12" stroke-width="2" stroke="currentColor" fill="none" />
                      </svg>`,
            },
            {
              id: 47,
              label: "Clear cache",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24">
                        <path d="M12 2C6.486 2 2 6.486 2 12s4.486 10 10 10 10-4.486 10-10S17.514 2 12 2zm0 18a8 8 0 110-16 8 8 0 010 16zm0-10a1 1 0 00-1 1v3a1 1 0 002 0v-3a1 1 0 00-1-1z" fill="currentColor" />
                      </svg>`,
            },
          ],
        },
        {
          id: 48,
          label: "Payment and logs",
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="12" cy="12" r="9" />  <path d="M14.8 9a2 2 0 0 0 -1.8 -1h-2a2 2 0 0 0 0 4h2a2 2 0 0 1 0 4h-2a2 2 0 0 1 -1.8 -1" />  <path d="M12 6v2m0 8v2" /></svg>`,
          children: [
            {
              id: 49,
              label: "Payment logs",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24">
                        <rect x="3" y="5" width="18" height="14" rx="2" stroke-width="2" stroke="currentColor" fill="none" />
                        <path d="M8 15h4M8 12h8M8 9h6" stroke-width="2" stroke="currentColor" fill="none" />
                      </svg>`,
            },
            {
              id: 50,
              label: "Payment",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <rect x="3" y="5" width="18" height="14" rx="3" />  <line x1="3" y1="10" x2="21" y2="10" />  <line x1="7" y1="15" x2="7.01" y2="15" />  <line x1="11" y1="15" x2="13" y2="15" /></svg>`,
            },
          ],
        },
        {
          id: 51,
          label: `Manager's cabinet`,
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z"/>
                  </svg>`,
          children: [
            {
              id: 52,
              label: "Manager A",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                        <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/>
                      </svg>`,
            },
            {
              id: 53,
              label: "Manager B",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                        <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/>
                      </svg>`,
            },
          ],
        },
        {
          id: 54,
          label: `Users`,
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  fill="none" viewBox="0 0 24 24" stroke="currentColor">
                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M17 20h5v-2a3 3 0 00-5.356-1.857M17 20H7m10 0v-2c0-.656-.126-1.283-.356-1.857M7 20H2v-2a3 3 0 015.356-1.857M7 20v-2c0-.656.126-1.283.356-1.857m0 0a5.002 5.002 0 019.288 0M15 7a3 3 0 11-6 0 3 3 0 016 0zm6 3a2 2 0 11-4 0 2 2 0 014 0zM7 10a2 2 0 11-4 0 2 2 0 014 0z"/>
                  </svg>`,
        },
        {
          id: 53,
          label: `Reference books`,
          routerClass:
            "inline-flex relative items-center py-[10px] px-[10px] w-full text-sm font-medium border-gray-200 bg-gray-700 hover:bg-gray-300 hover:text-gray-800 transition duration-400 ease-in-out",
          path: "/category",
          svg: `<svg class="h-5 w-5 text-white-300"  viewBox="0 0 24 24"  fill="none"  stroke="currentColor"  stroke-width="2"  stroke-linecap="round"  stroke-linejoin="round">  <path d="M4 19.5A2.5 2.5 0 0 1 6.5 17H20" />  <path d="M6.5 2H20v20H6.5A2.5 2.5 0 0 1 4 19.5v-15A2.5 2.5 0 0 1 6.5 2z" /></svg>`,
          children: [
            {
              id: 54,
              label: "Car marks",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="7" cy="17" r="2" />  <circle cx="17" cy="17" r="2" />  <path d="M5 17h-2v-6l2-5h9l4 5h1a2 2 0 0 1 2 2v4h-2m-4 0h-6m-6 -6h15m-6 0v-5" /></svg>`,
            },
            {
              id: 55,
              label: "Car marks",
              routerClass:
                "inline-flex relative items-center py-[10px] px-[50px] w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-900 hover:text-white-800 transition duration-400 ease-in-out",
              path: "/category",
              svg: `<svg class="h-5 w-5 text-white"  width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">  <path stroke="none" d="M0 0h24v24H0z"/>  <circle cx="7" cy="17" r="2" />  <circle cx="17" cy="17" r="2" />  <path d="M5 17h-2v-6l2-5h9l4 5h1a2 2 0 0 1 2 2v4h-2m-4 0h-6m-6 -6h15m-6 0v-5" /></svg>`,
            },
          ],
        },
      ],
    };
  },
  methods: {
    //hide show side bar
    toogleSideBar() {
      this.showSide = !this.showSide;
    },
    //toogle user
    toogleDrop() {
      this.showDropDown = !this.showDropDown;
    },
  },
};
</script>

<style scoped>
@import "../../assets/css/app.css";

* {
  margin: 0;
  padding: 0;
}
.page-enter-active,
.page-leave-active {
  transition: 0.5s;
}

.page-enter,
.page-leave-to {
  opacity: 30%;
}
</style>
