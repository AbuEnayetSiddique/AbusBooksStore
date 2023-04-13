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
