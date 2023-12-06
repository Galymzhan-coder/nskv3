using Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FND.Interfaces
{
    public interface IBaseService
    {
        public IEnumerable<IDto> Index();
        public void create();
        public void update(int id, IDto dto);
        public void delete(int id);
        public IDto? getItem(int id);
    }
}
