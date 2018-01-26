using BussinessLayer;
using Data.Entities;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Katmanlı_Mimari_Example.Controllers
{
    public class HomeController : Controller
    {
        Repository<Student> _repoStudent = new Repository<Student>();
        public ActionResult Index()
        {
            return View(_repoStudent.List());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student _student)
        {
            _repoStudent.Insert(_student);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            Student _student = _repoStudent.GetById(Id);
           _repoStudent.Delete(_student);
            return RedirectToAction("Index");
        }
    }
}