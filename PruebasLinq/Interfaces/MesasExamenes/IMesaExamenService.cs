using InstitutoServices.Models.MesasExamenes;

namespace InstitutoServices.Interfaces.MesasExamenes
{
    public interface IMesaExamenService : IGenericService<MesaExamen>
    {
        public Task<List<MesaExamen>?> GetByTurnoAndCarreraAsync(int? idTurno, int? idCarrera);
    }
}
