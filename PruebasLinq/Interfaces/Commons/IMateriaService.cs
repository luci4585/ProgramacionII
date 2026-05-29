using InstitutoServices.Models;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Interfaces.Commons
{
    public interface IMateriaService : IGenericService<Materia>
    {
        public Task<List<Materia>?> GetByAnioCarreraAsync(int? id);
    }
}
