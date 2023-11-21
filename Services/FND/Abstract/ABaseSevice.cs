using Services.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FND.Abstract
{
    public abstract class ABaseSevice<T>
    {
        public abstract List<T> Index();
        public abstract void create();
        public abstract void update(int id);
        public abstract void delete(int id);
        
       
    }
}
