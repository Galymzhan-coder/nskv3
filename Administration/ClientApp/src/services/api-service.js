/* eslint-disable no-unused-vars */
import axios from "axios";

const host = 'https://localhost:7153/';

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

  // Функция для отправки данных
  async sendFile(url, data) {
    try {

      console.log('sendFile host + url = ', host + url, ', data = ', data);

      const response = await axios({
        method: 'post',
        url: host + url,
        data: data,
      });
      
      return response.data.imageUrl;
    } catch (error) {
      console.error('Failed to upload image:', error);
      return null;
    }
  }

  async fetchDataByType(url, type) {
    try {
      const responce = await axios.get(host + url, { params: { type: type } });
      return responce.data;
    } catch (error) {
      console.error('Error fetching data by type:', error);
      throw error;
    }
  }

  async fetchDataByTypeId(url, type, id) {
    try {
      const responce = await axios.get(host + url, { params: { type: type, id: id } });
      return responce.data;
    } catch (error) {
      console.error('Error fetching data by id:', error);
      throw error;
    }
  }
  

