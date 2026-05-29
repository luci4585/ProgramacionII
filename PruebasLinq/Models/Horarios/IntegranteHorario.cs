using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Models.Horarios
{
    public class IntegranteHorario : IEntityWithId
    {
        public int Id { get; set; }
        public int? HorarioId { get; set; }
        public Horario? Horario { get; set; } = null;
        public int? DocenteId { get; set; }
        public Docente? Docente { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Docente?.Nombre} {Horario?.Materia?.Nombre}" ?? string.Empty;
        }
    }
}
