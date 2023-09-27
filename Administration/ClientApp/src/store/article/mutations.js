export default {
  SET_BEGIN_DATE(state, beginDate) {
    state.beginDate = beginDate;
  },
  SET_END_DATE(state, endDate) {
    state.endDate = endDate;
  },
  SET_SEARCH_BY_NAME(state, value) {
    state.searchByName = value;
  },
  SET_ARTICLES(state, articles) {
    state.articles = articles;
  },
};
