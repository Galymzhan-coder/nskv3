using Models.DTO;
using Models.FFIFND;
using Services.FND.Interfaces;
using Services.Utils;
using Models.DTO.Interfaces;

namespace Services.FND
{
    public class CategoriesService:ICategoriesService, IBaseService
    {
        private ODDANP _odp;
        private string error ;
        public CategoriesService(ODDANP odp) 
        { 
            _odp = odp;
        }

        public IEnumerable<IDto> Index() 
        {
            string err = string.Empty;
            var sql = SqlCommandBuilder.BuildSelectCommand<CategoryDTO>("db_nsk.categories", "is_active=1");
            var lst = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, sql);

            return lst.ToList();
        }

        public void create()
        {

        }

        public void update(int id, IDto dto) 
        {
            var category = dto as CategoryDTO;
            if (category == null)
                return;

            string sql = SqlCommandBuilder.BuildUpdateCommand<CategoryDTO>(id, category);

            _odp.Routine.UpdateFromSql( sql, ref error);
        }

        public void delete(int id)
        {

        }

        public List<CategoryDTO> getCategoryHierarchyLst() 
        {

            string err = string.Empty;

            var sql = SqlCommandBuilder.BuildSelectCommand<CategoryDTO>("db_nsk.categories", "is_active=1");

            var lst = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, sql);

            return lst.ToList();

        }

        public CategoryDTO? getCategoryItem(int id)
        {

            string err = string.Empty;
 
            var sql = SqlCommandBuilder.BuildSelectCommand<CategoryDTO>("db_nsk.categories", $"is_active=1 and id={id}");
            
            var item = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, sql).FirstOrDefault();

            return item;

        }
       
        public IDto? getItem(int id)
        {
             string err = string.Empty;

            var sql = SqlCommandBuilder.BuildSelectCommand<CategoryDTO>("db_nsk.categories", $"is_active=1 and id={id}");

            var item = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, sql).FirstOrDefault();

            return item;

        }

    }
}
