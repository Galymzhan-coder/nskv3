<template>
  <transition name="page" mode="out-in">
    <router-view />
  </transition>
</template>

<style lang="scss">
// Import Main styles for this application
@import "styles/style";
.page-enter-active,
.page-leave-active {
    transition: 0.5s;
}

.page-enter,
.page-leave-to {
    opacity: 30%;
}
</style>
