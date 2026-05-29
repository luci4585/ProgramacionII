using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;

namespace InstitutoServices.Interfaces.Horarios
{
    public interface IDetalleHorarioService : IGenericService<DetalleHorario>
    {
        public Task<List<DetalleHorario>?> GetByCarreraAsync(int? idCicloLectivo, int? idCarrera);
        public Task<List<DetalleHorario>?> GetByAnioCarreraAsync(int? idCicloLectivo, int? idAnioCarrera);

    }
}
