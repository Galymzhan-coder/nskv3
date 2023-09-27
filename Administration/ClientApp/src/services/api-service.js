/* eslint-disable no-unused-vars */
import axios from "axios";

const host = 'http://localhost:5196/';

export default class ApiService {
  // Функция для получения данных
  async fetchData(url) {
    try {
      const response = await axios.get(host + url);
      return response.data;
    } catch (error) {
      console.error('Error fetching data:', error);
      throw error;
    }
  }

  async fetchDataById(url, id) {
    try {
      const responce = await axios.get(host + url, { params: { id: id } });
      return responce.data;
    } catch (error) {
      console.error('Error fetching data by id:', error);
      throw error;
    }
  }

  // Функция для отправки данных
  async sendData(url, data) {
    try {
      const response = await axios.post(host + url, data);
      return response.data;
    } catch (error) {
      console.error('Error sending data:', error);
      throw error;
    }
  }
}
    /*
// Пример использования
const apiUrl = 'https://api.example.com/data';

// Получение данных
fetchData(apiUrl)
  .then(data => {
    console.log('Fetched data:', data);
  })
  .catch(error => {
    console.error('Error:', error);
  });

// Отправка данных
const postData = { key: 'value' };
sendData(apiUrl, postData)
  .then(response => {
    console.log('Response:', response);
  })
  .catch(error => {
    console.error('Error:', error);
  });
*/

