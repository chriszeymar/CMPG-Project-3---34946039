using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Controllers;
namespace DeviceManagement_WebApp.Repository
{

    public class DeviceRepository
    {
        //private readonly ICategoryRepository _categoryRepository;
        //context instance
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        public Task GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid? id)
        {
            throw new NotImplementedException();
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var device = await _context.Device.FindAsync(id);
            _context.Device.Remove(device);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceExists(Guid id)
        {
            return _context.Device.Any(e => e.DeviceId == id);
        }
        // POST: Devices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            if (id != device.DeviceId)
            {
                return null;
            }
            try
            {
                _context.Update(device);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(device.DeviceId))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }
        // POST: Devices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            device.DeviceId = Guid.NewGuid();
            _context.Add(device);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }


    }


}
