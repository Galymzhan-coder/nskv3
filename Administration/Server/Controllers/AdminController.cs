using Microsoft.AspNetCore.Mvc;

namespace Administration.Server.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        /// <summary>
        /// Информация о пользователе в базе FFI
        /// </summary>
        /// <param name="id">id договора</param>
        /// <returns></returns>
        [HttpGet("IndexAdmin"), ApiVersion("1")]
        public ActionResult Index()
        {
            return View();
        }
        /*
        // GET: AdminController
        /// <summary>
        /// Информация о пользователе в базе FFI
        /// </summary>
        /// <param name="id">id договора</param>
        /// <returns></returns>
        [HttpGet("IndexAdmin"), ApiVersion("1")]
        public List<Category> getCategorylist()
        {
            DbNskContext context = DbNskContext.Current;
            context.Categories.Where(t => t.IsActive==1).ToList();
            return context.Categories.Where(t => t.IsActive == 1).ToList();
        }
        */
        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
