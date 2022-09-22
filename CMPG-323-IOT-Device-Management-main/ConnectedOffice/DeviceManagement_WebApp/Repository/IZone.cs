using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        //Zone GetMostRecentService();
        Task GetById(Guid? id);
        Task Remove(Guid? id);
    }

}
