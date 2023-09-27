export default {
    SET_USER(state, user) {
      state.user = user
      localStorage.setItem('username', user.data.firstName)
    },
    SET_TOKEN(state, token) {
      state.token = token
      localStorage.setItem('token', token)
    },
    SET_AUTH(state, isAuthenticated) {
      state.isAuthenticated = isAuthenticated
      localStorage.setItem('authenticate', isAuthenticated)
    },
    SET_ERROR(state, error) {
      state.errors = error
    },
    SET_ANIMATE_CLICKED(state, isClicked) {
      state.isClicked = isClicked
    },
    SET_ANIMATE_VALIDATED(state, isValidated) {
      state.isValidated = isValidated
    },
  }
  