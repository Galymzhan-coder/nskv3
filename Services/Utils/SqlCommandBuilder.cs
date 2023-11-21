using Services.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
