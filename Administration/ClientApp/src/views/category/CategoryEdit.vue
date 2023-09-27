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
            <!--<textarea v-model="itemsEdit.description" class="p-2 border w-full text-left resize-none" ></textarea>-->
            <!--RichTextEditor/-->
            

            <div class="p-2">
              <!--TextEditor :tools="['code', 'link']" class="p-2 border w-full text-left resize-none" v-model="itemsEdit.description" />-->

              <quill-editor v-model:value="itemsEdit.description"
                            :options="state.editorOption"
                            :disabled="state.disabled"
                            @blur="onEditorBlur($event)"
                            @focus="onEditorFocus($event)"
                            @ready="onEditorReady($event)"
                            @change="onEditorChange($event)" />

            </div>
            <div class="p-2 border w-full text-left inline-flex items-center">
              <input v-model="itemsEdit.is_active" type="checkbox" class="mr-2" />
              <label>Активность:</label>
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
  import { ref, defineProps, defineEmits, onMounted, watch/*, computed*/ } from 'vue';

  //import RichTextEditor from '../../components/RichTextEditor';
  //import TextEditor from '../../components/TextEditor';
  import { useRouter, useRoute,  } from 'vue-router';
  import ApiService from '../../services/api-service.js';

  import { reactive } from 'vue'
  import { quillEditor } from 'vue3-quill'
  
  const items = ref([]);
  const apiService = new ApiService();
  const itemsEdit = ref(null);
  let selectedItem = ref(null);
  /*
  onMounted(async () => {
      const { data } = apiService.fetchData('CategoryIerarchyList')
      .then(data => {
        console.log('Fetched data:', data);
      })
      .catch(error => {
        console.error('Error:', error);
      });

      this.items = data;
  });
  */

  const router = useRouter();
  const route = useRoute();

  onMounted(async () => {
    try {
      const data = await apiService.fetchData('CategoryIerarchyList');
      items.value = data;
      console.log("router=", router);
      //selectedItem = ref(items.value.find(item => item.id === itemsEdit.parentId)?.title || null);
      //selectedItem = ref(items.value.map(item => item.id == itemsEdit.parentId).values);
      
      let id = route.params.id;
      const editData = await apiService.fetchDataById('GetCategoryItem', id);
      itemsEdit.value = editData;
      selectedItem = items.value.find(item => item.id === editData.parent_id);
      //formItems.id = editData.id;
      
      console.log("selectedItem=", selectedItem, ", editData.parent_id=", editData);
      console.log("itemsEdit=", itemsEdit);
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  });
  /*
  const descriptionValue = computed(() => itemsEdit && itemsEdit.description);
  const description = computed({
    get: () => itemsEdit && itemsEdit.description,
    set: (value) => {
      if (itemsEdit) {
        itemsEdit.description = value;
      }
    },
  });
  /*
  selectedItem = computed(() => {
    const item = items.value.find(item => item.id === itemsEdit.value.parent_id);
    return item ? item : null;
  });
  */
  //const selectedItem = ref(items.value.find(item => item.id === itemsEdit.parentId)?.title || null);

  watch(selectedItem, (newValue) => {
    // newValue содержит новое выбранное значение
    formData.value.parentId = newValue; // Предполагается, что у formData есть свойство parentId, измените это на ваше актуальное свойство
  });
  /*
  const formItems = {
        id: 0,
        parentId: null,
        title: "",
        sefname: "",
        description: "",
        isActive: null,
        createDate: "",
        updateDate: "",
        root: 0,
        lft: 0,
        rgt: 0,
        level: 0
  };
  */
  const props = defineProps(['item']);
  const emit = defineEmits(['save', 'cancel']);

  const formData = ref({ ...props.item });

  function saveItem() {
    emit('save', formData.value);
  }

  function cancel() {
    //emit('cancel');
    goToPage('/category');
  }
  
  function goToPage(url) {
    router.push(url);
  }
  /*
  onMounted(async () => {
    try {
      const data = await apiService.fetchData('Index');
      items.value = data;
      var id = this.$route.params.id;
      console.log('id=',id);
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  });

  onMounted(async () => {
    try {
      const data = await apiService.fetchData('GetCategoryItem');
      items.value = data;
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  });
  */


    const state = reactive({
      dynamicComponent: null,
      content: '<p>Initial Content</p>',
      _content: '',
      editorOption: {
        placeholder: 'core',
        modules: {
          toolbar: [
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
          // other moudle options here
        }
        // more options
      },
      disabled: false
    })
    const onEditorBlur = quill => {
      console.log('editor blur!', quill)
    }
    const onEditorFocus = quill => {
      console.log('editor focus!', quill)
    }
    const onEditorReady = quill => {
      console.log('editor ready!', quill)
    }
    const onEditorChange = ({ quill, html, text }) => {
      console.log('editor change!', quill, html, text)
      state._content = html
    }
    /*
    setTimeout(() => {
      state.disabled = true
    }, 2000)*/


</script>

<style>
  /* Стили для модального окна (пример) */
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
