using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task GetById(Guid? id);
        Task Remove(Guid? id);
    }

}
