import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import { Form, Field, ErrorMessage, configure } from "vee-validate";
import store from "@/store";

configure({
  validateOnInput: true,
});

const app = createApp(App);
app
  .component("Form", Form)
  .component("Field", Field)
  .component("ErrorMessage", ErrorMessage);

app.use(router, store);

app.mount("#app");
