<template>
    <div class="text-editor">
      <quillEditor
        v-model.trim:value="state.content"
        :options="state.editorOption"
        @ready="onEditorReady($event)"
        @change="onEditorChange($event)"
      />
    </div>
  </template>
  
  <script>
  import { quillEditor/*, Quill*/ } from "vue3-quill";
  import { reactive } from "vue";
  
  // import customQuillModule from 'customQuillModule'
  // Quill.register('modules/customQuillModule', customQuillModule)
  
  export default {
    components: {
      quillEditor,
    },
  
    props: {
      placeholder: String,
      tools: Array,
    },
  
    setup() {
      const state = reactive({
        content: "<p>2333</p>",
        _content: "",
        editorOption: {
          placeholder: "Tell us a bit about yourself",
          modules: {
            toolbar: [
              [{ header: [1, 2, false] }],
              ["bold", "italic", "underline", 'strike'],
              ["code", "link"],
                [{ 'align': [] }],
                [{ 'list': 'ordered'}, { 'list': 'bullet' }],
                ['link', 'image']
            ],
          },
          // more options
        },
        disabled: false,
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
        console.log("html", html);
        console.log("text", text);
        console.log("content", state._content);
      };
  
      setTimeout(() => {
        state.disabled = true;
      }, 2000);
  
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