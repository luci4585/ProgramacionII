using InstitutoServices.Enums;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Models.Horarios
{
    public class DetalleHorario : IEntityWithId
    {
        public int Id { get; set; }
        public int? HorarioId { get; set; }
        public Horario? Horario { get; set; } = null;
        public int? AulaId { get; set; }
        public Aula? Aula { get; set; } = null;
        public DiaEnum Dia { get; set; } = 0;
        public int? HoraId { get; set; }
        public Hora? Hora { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Dia} {Hora?.Nombre} {Horario?.Materia?.Nombre}" ?? string.Empty;
        }
    }
}
