using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Task GetById(Guid? id);
        Task Remove(Guid? id);
    }

}
