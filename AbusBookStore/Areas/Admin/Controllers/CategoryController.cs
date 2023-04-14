using AbusBooks.DataAccess.Repository;
using AbusBooks.DataAccess.Repository.IRepository;
using AbusBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbusBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            category = _unitOfwork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category); //remember
        }

        //Use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid) //Checks all the Validation in the model (e.g. Name Required) to increase security
            {
                if (category.Id == 0)
                {
                    _unitOfwork.Category.Add(category);
                }
                else
                {
                    _unitOfwork.Category.Update(category);
                }
                _unitOfwork.Save();
                return RedirectToAction(nameof(Index)); //To see all the Categories
            }
            return View(category);
        }



        //APT calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfwork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
