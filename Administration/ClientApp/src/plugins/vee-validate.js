import * as yup from 'yup'

const schemaRules = {
  username: yup
    .string()
    .required('Необходимо заполнить «Имя пользвоателя»')
    .min(5, 'Поле должно быть не менее 5 символов')
    .max(30, 'Поле должно быть не более 30 символов'),
  password: yup
    .string()
    .required('Необходимо заполнить «Пароль»')
    .min(2, 'Поле должно быть не менее 8 символов')
    .max(30, 'Поле должно быть не более 30 символов'),
}

export { schemaRules }
