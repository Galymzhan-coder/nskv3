<template>
  <div class="p-4 border">
    <div>
      <h2>Редактировать запись</h2>

      <div class="flex flex-col">
        <div class="grid grid-cols-6 gap-0" style="grid-template-columns: 550px">
          <form @submit.prevent="saveItem" v-if="itemsEdit">

            <div class="bg-gray-300 p-2 border"><label>Наименование:</label></div>
            <input type="text" class="p-2 border w-full text-left" v-model="itemsEdit.title" />

            <div class="bg-gray-300 p-2 border"><label>Родитель:</label></div>
            <div class="p-2 border w-full text-left">
              <select v-model="selectedItem">
                <option disabled value="">Выберите значение</option>
                <option v-for="item in items" :key="item.id" :value="item">{{ item.title }}</option>
              </select>
            </div>

            <div class="bg-gray-300 p-2 border"><label>ЧПУ:</label></div>
            <input v-model="itemsEdit.sefname" type="text" class="p-2 border w-full text-left" />

            <div class="bg-gray-300 p-2 border"><label>Описание:</label></div>


            <div class="p-2">

              <quill-editor v-model="content"
                            :options="state.editorOption"
                            :disabled="state.disabled"
                            @blur="onEditorBlur($event)"
                            @focus="onEditorFocus($event)"
                            @ready="onEditorReady($event)"
                            @change="onEditorChange($event)" />

            </div>
            <div class="p-2 border w-full text-left inline-flex items-center">
              <label>Активность:</label> &nbsp;
              <input v-model="itemsEdit.is_active" type="checkbox" class="mr-2" />

            </div>
            <div class="p-2"></div>
            <div class="p-2 w-full inline-flex items-center space-x-4">
              <button type="submit" class="bg-gray-300 py-2 px-4 rounded">Сохранить</button>
              <button @click="cancel" class="bg-gray-300 py-2 px-4 rounded">Отмена</button>
            </div>


          </form>
        </div>
      </div>

    </div>
  </div>
</template>

<script setup>
  import { ref, defineProps, defineEmits, onMounted, watch } from 'vue';

  import { useRouter, useRoute, } from 'vue-router';
  import ApiService from '../../services/api-service.js';

  import { reactive } from 'vue'
  import { quillEditor } from 'vue3-quill'

  const items = ref([]);
  const apiService = new ApiService();
  const itemsEdit = ref(null);
  let selectedItem = ref(null);
  let content = "";
  let quillInstance = ref(null);

  const router = useRouter();
  const route = useRoute();

  onMounted(async () => {
    try {
      const data = await apiService.fetchData('CategoryIerarchyList');
      items.value = data;

      let id = route.params.id;
      const editData = await apiService.fetchDataByTypeId('GetItem', 'categories' , id);
      itemsEdit.value = editData;
      selectedItem = items.value.find(item => item.id === editData.parent_id);

      itemsEdit.value.is_active = itemsEdit.value.is_active === 1 ? true : false;

    } catch (error) {
      console.error('Error fetching data:', error);
    }
  });

  watch(selectedItem, (newValue) => {
    formData.value.parent_id = newValue; 
  });
  
  const props = defineProps(['item']);
  const emit = defineEmits(['save', 'cancel']);

  const formData = ref({ ...props.item });

  async function saveItem() {


    console.log('this.itemsEdit =', this.itemsEdit);

    try {
      let id = route.params.id;
      const postData = { type: 'categories', id: id, dto: this.itemsEdit };
      await apiService.sendData('Update', postData);

    } catch (error) {
      console.log("saveItem error = ", error);
    }
    
    emit('save', formData.value);
  }

  function cancel() {
    goToPage('/category');
  }

  function goToPage(url) {
    router.push(url);
  }

  const uploadImage = async (file) => {
    const formData = new FormData();
    formData.append('file', file);

    try {
      const response = await apiService.sendFile('upload-image', formData);//await axios.post('/api/upload-image', formData);
      console.log('uploadImage response = ', response);
      return response;
    } catch (error) {
      console.error('Failed to upload image:', error);
      return null;
    }
  }


  const state = reactive({
    dynamicComponent: null,
    content: '<p>Initial Content</p>',
    _content: '',
    editorOption: {
      placeholder: 'core',
      modules: {
        toolbar: {
          container: [
            ['bold', 'italic', 'underline', 'strike'],
            ['blockquote', 'code-block'],
            [{ header: 1 }, { header: 2 }],
            [{ list: 'ordered' }, { list: 'bullet' }],
            [{ script: 'sub' }, { script: 'super' }],
            [{ indent: '-1' }, { indent: '+1' }],
            [{ direction: 'rtl' }],
            [{ size: ['small', false, 'large', 'huge'] }],
            [{ header: [1, 2, 3, 4, 5, 6, false] }],
            [{ color: [] }, { background: [] }],
            [{ font: [] }],
            [{ align: [] }],
            ['clean'],
            ['link', 'image', 'video']
          ],
          handlers: {
            image: () => {
              const input = document.createElement('input');
              input.setAttribute('type', 'file');
              input.click();

              input.onchange = async () => {
                const file = input.files[0];
                const imageUrl = await uploadImage(file);
                if (imageUrl) {
                  true
                  const range = quillInstance.value.getSelection(true);
                  quillInstance.value.insertEmbed(range.index, 'image', imageUrl);
                }
              };
            }
          }
        }
      },
      disabled: false
    }
  });
  const onEditorBlur = quill => {
    console.log('editor blur!', quill)
  }
  const onEditorFocus = quill => {
    console.log('editor focus!', quill)
  }
  const onEditorReady = quill => {
    quillInstance.value = quill;
    console.log('editor ready!', quill)
  }
  const onEditorChange = ({ quill, html, text }) => {
    
    state._content = html;
    itemsEdit.value.description = html;

 }


</script>

<style>
  /* Стили для модального окна */
  .modal {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: rgba(0, 0, 0, 0.5);
    display: flex;
    justify-content: center;
    align-items: center;
  }

  .modal-content {
    background-color: white;
    padding: 20px;
  }
</style>
