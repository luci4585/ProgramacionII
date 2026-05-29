using InstitutoServices.Models;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Interfaces.Commons
{
    public interface IAnioCarreraService : IGenericService<AnioCarrera>
    {
        public Task<List<AnioCarrera>?> GetByCarreraAsync(int? id);
    }
}
