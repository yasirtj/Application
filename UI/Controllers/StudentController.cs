using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Student;
using Application.Student.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.ViewModels;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly ICreateStudent _createStudent;
        public StudentController(ICreateStudent createStudent)
        {
            _createStudent = createStudent;
        }

        // GET: Student
        public ActionResult Index(StudentViewModel studentViewModel)
        {

            var studentsList = new List<StudentModel>();
            foreach (var item in studentsList)
            {
                studentsList.Add(new StudentModel
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return View(studentViewModel);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                _createStudent.Go(new StudentModel
                {

                    Name = studentViewModel.Name,


                });

                return RedirectToAction("Index");

            }
            return View(studentViewModel);
        }
            //    try
            //    {
            //        var viewModelToModel = ConvertToModel(StudentViewModel studentViewModel);
            //        _createStudent.Go(viewModelToModel);

            //        return RedirectToAction(nameof(Index));
            //    }
            //    catch
            //    {
            //        return View(viewModelToModel);
            //    }
            //}

            // GET: Student/Edit/5
            public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public StudentViewModel ConvertToModel(StudentViewModel studentViewModel)
        //{
           
        //    var model = new StudentModel();
        //    model.Id = studentViewModel.Id;
        //    model.Name = studentViewModel.Name;
        //    return model;
        //}
        
    }
}