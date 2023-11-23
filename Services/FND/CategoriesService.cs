﻿using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.FFIFND;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Services.FND.Interfaces;
using Services.Utils;

namespace Services.FND
{
    public class CategoriesService:ICategoriesService
    {
        private ODDANP _odp;
        private string error ;
        public CategoriesService(ODDANP odp) 
        { 
            _odp = odp;
        }

        public List<CategoryDTO> Index() 
        {
            string err = string.Empty;
            var lst = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, "select * from db_nsk.categories where is_active=1");


            return lst.ToList();
        }

        public void create()
        {

        }

        public void update(int id, CategoryDTO category) 
        {
            string sql = SqlCommandBuilder.BuildUpdateCommand<CategoryDTO>(id, category);

            _odp.Routine.UpdateFromSql( sql, ref error);
        }

        public void delete(int id)
        {

        }

        public List<CategoryDTO> getCategoryHierarchyLst() 
        {
            //ODDANP odp = new ODDANP(new NPRoutine());
            //var yourClass = HttpContext.RequestServices.GetService<NPRoutine>();

            string err=string.Empty;
            var lst = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, "select * from db_nsk.categories where is_active=1");
            

            return lst.ToList();

        }

        public CategoryDTO? getCategoryItem(int id)
        {
            //ODDANP odp = new ODDANP(new NPRoutine());
            //var yourClass = HttpContext.RequestServices.GetService<NPRoutine>();

            string err = string.Empty;
            var item = _odp.Routine.GetFromDatabase<CategoryDTO>(ref err, $"select * from db_nsk.categories where is_active=1 and id={id}").FirstOrDefault();


            return item;

        }
    }
}
