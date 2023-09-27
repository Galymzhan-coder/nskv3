<template>
    <div class="text-editor">
      <quillEditor
        :model-value="state.content"
        :options="state.editorOption"
        @ready="onEditorReady($event)"
        @change="onEditorChange($event)"
      />
    </div>
  </template>
  
  <script>
  import { quillEditor/*, Quill*/ } from "vue3-quill";
  import { reactive, watch } from "vue";
  
  // import customQuillModule from 'customQuillModule'
  // Quill.register('modules/customQuillModule', customQuillModule)
  
  export default {
    components: {
      quillEditor,
    },
  
    props: {
      value: String,
      placeholder: String,
      tools: Array,
    },
    emits: ['update:modelValue'],


    setup(props, { emit } ) {
      const state = reactive({
        content: props.value,
        _content: "",
        editorOption: {
          placeholder: "Tell us a bit about yourself",
          modules: {
            /*toolbar: [
              [{ header: [1, 2, false] }],
              ["bold", "italic", "underline", 'strike'],
              ["code", "link"],
                [{ 'align': [] }],
                [{ 'list': 'ordered'}, { 'list': 'bullet' }],
                ['link', 'image']
            ],*/
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
          },
          // more options
        },
        disabled: false,
      });

       // Добавляем наблюдатель, чтобы отслеживать изменения внешнего значения
      watch(() => props.value, (newValue) => {
        state.content = newValue;
      });
  
      const onEditorBlur = (quill) => {
        console.log("editor blur!", quill);
      };
      const onEditorFocus = (quill) => {
        console.log("editor focus!", quill);
      };
      const onEditorReady = (quill) => {
        console.log("editor ready!", quill);
      };
      const onEditorChange = ({ /*quill,*/ html, text }) => {
        // console.log("editor change!", quill, html, text);
        state._content = html;
        //this.props.value= html;
        emit('update:modelValue', html);
        //emit('input', html); 
        console.log("html", html);
        console.log("text", text);
        console.log("content", state._content);
      };
  
      setTimeout(() => {
        state.disabled = true;
      }, 2000);

      // Определяем функцию, которая будет обновлять внешнее значение при изменении
    const updateValue = () => {
      emit("update:value", state.content);
    };

    // Вызываем функцию обновления значения при изменении content
    watch(() => state.content, updateValue);

      return {
        state,
        onEditorBlur,
        onEditorFocus,
        onEditorReady,
        onEditorChange,
      };
    },
  };
  </script>
