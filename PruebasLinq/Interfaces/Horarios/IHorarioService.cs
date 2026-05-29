using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;

namespace InstitutoServices.Interfaces.Horarios
{
    public interface IHorarioService : IGenericService<Horario>
    {
        public Task<List<Horario>?> GetByCarreraAsync(int? idCicloLectivo, int? idCarrera);
    }
}
