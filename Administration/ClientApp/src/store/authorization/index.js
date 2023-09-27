import actions from "./actions";
import getters from "./getters";
import mutations from "./mutations";
import state from "./state";

const authStore = {
    state,
    actions,
    mutations,
    getters
}

export { authStore }