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
    public class ZonesController : Controller
    {
        //Create new pattern instance
        private readonly IZoneRepository _zoneRepository;
        //new pattern constructor
        public ZonesController(IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
        }

        // GET: Zones
        public async Task<IActionResult> Index()
        {
            return View(_zoneRepository.GetAll());
        }

        // GET: Zones/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            //Returnt if ID empty
            if (id == null)
            {
                return NotFound();
            }

            //assign id to declared variables
            var zone = _zoneRepository.GetById(id);
            //return not found if parsed ID is not found in DB
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

        // GET: Zones/Create
        public IActionResult Create()
        {
            return View();
        }

        

        // GET: Zones/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = _zoneRepository.GetById(id);
            if (zone == null)
            {
                return NotFound();
            }
            return View(zone);
        }

      
        // GET: Zones/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = _zoneRepository.GetById(id);
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

    }
}
