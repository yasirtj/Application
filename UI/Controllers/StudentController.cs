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
        public ActionResult Index(StudentModel model)
        {
            return View(model);
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
        public ActionResult Create(StudentViewModel viewModel)
        {
            try
            {
                var ViewToModel = Convert(viewModel);
                _createStudent.Go(ViewToModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

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

        public StudentModel Convert(StudentViewModel viewModel)
        {
            var model = new StudentModel();
            model.Id = viewModel.Id;
            model.Name = viewModel.Name;
            return model;
        }
    }
}