using BussinessLayer;
using Data.Entities;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Katmanlı_Mimari_Example.Controllers
{
    public class HomeController : Controller
    {
        StudentManager _repoStudent = new StudentManager();
        public ActionResult Index()
        {
            var studentList = _repoStudent.List();
            return View(studentList);
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
        public ActionResult Delete(int? Id)
        {
            Student _student = _repoStudent.Find(m=>m.Id == Id);
           _repoStudent.Delete(_student);
            return RedirectToAction("Index");
        }
        

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Student _student = _repoStudent.Find(x => x.Id == id.Value);

            if (_student == null)
            {
                return HttpNotFound();
            }
            return View(_student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student _student)
        {
            if (ModelState.IsValid)
            {
                var st = _repoStudent.Find(x => x.Id == _student.Id);
                st.StudentName = _student.StudentName;
                _repoStudent.Update(st);
                return RedirectToAction("Index");
            }
            return View(_student);
        }
    }
}