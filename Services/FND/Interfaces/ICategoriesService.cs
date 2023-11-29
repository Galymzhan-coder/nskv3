using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FND.Interfaces
{
    public interface ICategoriesService 
    {
        public List<CategoryDTO> getCategoryHierarchyLst();

        public CategoryDTO? getCategoryItem(int id);
        
    }
}
