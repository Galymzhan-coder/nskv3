using Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utils
{
    public class SqlCommandBuilder
    {
        public static string BuildUpdateCommand<T>(int id, T dto) where T : IDto
        {
            string tabName = typeof(T).Name;

            if (tabName.EndsWith("DTO"))
                tabName = tabName[..^3];


            // Начало конструкции SQL запроса
            var sql = new StringBuilder($"UPDATE {tabName} SET ");

            // Получение свойств DTO
            var properties = typeof(T).GetProperties();

            var parameters = new List<string>();
            foreach (var property in properties)
            {
                // Добавление каждого свойства как параметра SQL запроса
                parameters.Add($"{property.Name} = @{property.Name}");
            }

            // Соединяем параметры в SQL запросе
            sql.Append(string.Join(", ", parameters));

            // Добавление условия WHERE для обновления по ID
            sql.Append(" WHERE id = @id");

            // В этом месте вы должны добавить параметры в вашу команду SQL
            // Например, cmd.Parameters.AddWithValue("@propertyName", propertyValue);

            return sql.ToString();
        }

        public static string BuildSelectCommand<T>(string tableName, string whereConditions = "") where T : IDto
        {
            var properties = typeof(T).GetProperties()
                .Where(prop => prop.CanRead)
                .Select(prop => prop.Name);

            var fields = string.Join(", ", properties);
            var sql = $"SELECT {fields} FROM {tableName}";

            if (!string.IsNullOrEmpty(whereConditions))
            {
                sql += $" WHERE {whereConditions}";
            }

            return sql;
        }
        /*
        public static string BuildSelectCommand<TDto>(string tableName, string whereConditions = "")
        {
            var properties = typeof(TDto)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead)
                .Select(p => p.Name);

            var columns = string.Join(", ", properties);
            var sql = new StringBuilder($"SELECT {columns} FROM {tableName}");

            if (!string.IsNullOrEmpty(whereConditions))
            {
                sql.Append($" WHERE {whereConditions}");
            }

            return sql.ToString();
        }
        */
        /*
        public static string BuildSelectCommand<TDto>() where TDto : IDto
        {
            var type = typeof(TDto);
            var tableName = GetTableName(type); // Метод для получения имени таблицы из типа DTO
            var columnNames = type.GetProperties()
                                  .Select(p => p.Name)
                                  .ToList();

            var selectClause = string.Join(", ", columnNames);
            var sql = $"SELECT {selectClause} FROM {tableName}";

            return sql;
        }

        public static string GetTableName(Type type)
        {
            var tableNameAttribute = type.GetCustomAttribute<TableNameAttribute>();
            if (tableNameAttribute != null)
            {
                return tableNameAttribute.Name;
            }

            // Если атрибут не найден, можно вернуть имя класса или бросить исключение
            return type.Name; // или throw new InvalidOperationException("Table name not defined for " + type.Name);
        }

        public class TableNameAttribute : Attribute
        {
            public string Name { get; }

            public TableNameAttribute(string name)
            {
                Name = name;
            }
        }*/
    }
}
