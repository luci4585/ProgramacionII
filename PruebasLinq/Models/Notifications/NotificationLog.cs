using InstitutoServices.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Notifications
{
    public class NotificationLog
    {
        public long Id { get; set; }

        // 🔧 Ajuste rápido: si tu Usuario.Id NO es Guid, cambiá Guid por int/long aquí y en UserDevice
        public int UserId { get; set; }

        /// <summary>
        /// Opcional: si logueás por dispositivo, vinculás.
        /// Recomendación: mantener ambos (UserId para idempotencia por usuario + DeviceId para auditoría).
        /// </summary>
        public long? DeviceId { get; set; }
        public UserDevice? Device { get; set; }

        /// <summary>
        /// Identificador de la mesa de examen. Ajustá el tipo a tu PK real (Guid/int/long).
        /// </summary>
        public int MesaExamenId { get; set; }

        public NotificationType Type { get; set; }

        public NotificationStatus Status { get; set; } = NotificationStatus.Pending;

        /// <summary>
        /// Momento para el cual correspondía el aviso (ej: examStart - 24h).
        /// </summary>
        public DateTimeOffset ScheduledForUtc { get; set; }

        public DateTimeOffset? SentUtc { get; set; }

        /// <summary>
        /// MessageId devuelto por FCM (si lo tenés)
        /// </summary>
        public string? ProviderMessageId { get; set; }

        /// <summary>
        /// Error corto, no guardes stack traces gigantes.
        /// </summary>
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }

        public DateTimeOffset CreatedUtc { get; set; } = DateTimeOffset.UtcNow;
    }
}
