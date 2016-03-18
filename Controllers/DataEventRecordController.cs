using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using sqlite.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace sqlite.Controllers
{
    public class DataEventRecordController : Controller
    {
        private DataEventRecordContext context;

        public DataEventRecordController(DataEventRecordContext context)
        {
          this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(this.context.DataEventRecords.ToList());
        }

        public IActionResult Create()
        {
          return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DataEventRecord record)
        {
          if (ModelState.IsValid) {
            this.context.DataEventRecords.Add(record);
            this.context.SaveChanges();
            return RedirectToAction("Index");
          }

          return View(record);
        }
    }
}
