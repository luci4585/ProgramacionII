using InstitutoServices.Models;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Interfaces.Inscripciones
{
    public interface IDetalleInscripcionService : IGenericService<DetalleInscripcion>
    {
        public Task<List<DetalleInscripcion>?> GetByInscripcionAsync(int? id);
        public Task<bool> CheckDuplicadoDetalleInscripcionAsync(int?idDetalle, int? idInscripcion, int? idMateria);
    }
}
