﻿using AbusBooks.DataAccess.Repository;
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
        public class CoverTypeController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public CoverTypeController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Upsert(int? id)
            {
                CoverType coverType = new CoverType();
                if (id == null)
                {
                    // this is for create
                    return View(coverType);
                }
                // this is for edit
                coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
                if (coverType == null)
                {
                    return NotFound();
                }
                return View(coverType); //remember
        }

            //Use HTTP POST to define the post-action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(CoverType coverType)
            {
                if (ModelState.IsValid)
                {
                    if (coverType.Id == 0)
                    {
                        _unitOfWork.CoverType.Add(coverType);
                    }
                    else
                    {
                        _unitOfWork.CoverType.Update(coverType);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(coverType);
            }

            //APT calls here
            #region API CALLS

            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.CoverType.GetAll();
                return Json(new { data = allObj });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.CoverType.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting" });
                }
                _unitOfWork.CoverType.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete Successful" });
            }

            #endregion
        }
    }
