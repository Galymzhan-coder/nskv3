using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.FFIFND;

namespace Services.FND
{
    public class UserService
    {
        public List<UserDTO> Index()
        {
            ODDANP odp = new ODDANP();

            string err = string.Empty;
            var lst = odp.Routine.GetFromDatabase<UserDTO>(ref err, "select * from db_nsk.users where is_active=1");


            return lst.ToList();
        }

        public UserDTO GetUserByParam(string username)
        {
            ODDANP odp = new ODDANP();

            string err = string.Empty;
            var usr = odp.Routine.GetFromDatabase<UserDTO>(ref err, "select * from db_nsk.users where username='"+ username+"'").SingleOrDefault();


            return usr;
        }
    }
}
