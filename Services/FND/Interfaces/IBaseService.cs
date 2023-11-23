using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FND.Interfaces
{
    public interface IBaseService<T>
    {
        public List<T> Index();
        public void create();
        public void update(int id,T dto);
        public void delete(int id);
    }
}
