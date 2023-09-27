import axios from 'axios'
import router from '@/router'

export default {
  async login({ commit }, { username, password }) {
    try {
      const postData = new FormData()

      postData.append('username', username)
      postData.append('password', password)

      commit('SET_ANIMATE_CLICKED', true)

      const user = await axios.post(
        `http://localhost:5196/Authenticate`,
        postData,
      )
      if (user.status === 200) {
        commit('SET_AUTH', true)
        commit('SET_USER', user)
        commit('SET_TOKEN', user.data.token)

        setTimeout(() => {
          commit('SET_ANIMATE_CLICKED', false)
          commit('SET_ANIMATE_VALIDATED', true)
        }, 1000)

        setTimeout(() => {
          router.push({ name: 'Dashboard' })
          commit('SET_ANIMATE_VALIDATED', false)
        }, 1500)
      }
    } catch (error) {
      setTimeout(() => {
        commit('SET_ANIMATE_CLICKED', false)
        commit('SET_ERROR', error.response.data.message)
      }, 1000)
    }
  },
}
