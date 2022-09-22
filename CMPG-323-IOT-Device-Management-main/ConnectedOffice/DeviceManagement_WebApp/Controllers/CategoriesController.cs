using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        //Create new pattern instance
        private readonly ICategoryRepository _categoryRepository;
        //new pattern constructor
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        //Get categories edited
        public async Task<IActionResult> Index()
        {
            return View(_categoryRepository.GetAll());
        }

        //Get: categories details - edited 

        public async Task<IActionResult> Details(Guid? id)
        {
            //Return not found if ID not found
            if (id == null)
            {
                return NotFound();
            }
            //assign category to declared variable
            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Categories/Edit/5 - edited
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

 

        // GET: Categories/Delete/5 - edited 
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryRepository.GetById(id);
  
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }


    }
}
