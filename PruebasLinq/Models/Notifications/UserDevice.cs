using InstitutoServices.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Notifications
{
    public class UserDevice
    {
        public long Id { get; set; }

        // 🔧 Ajuste rápido: si tu Usuario.Id NO es Guid, cambiá Guid por int/long aquí y en NotificationLog
        public int UserId { get; set; }

        /// <summary>
        /// Token FCM del navegador/dispositivo. Debe ser único globalmente.
        /// </summary>
        public string FcmToken { get; set; } = default!;

        /// <summary>
        /// "web", "android", "ios", etc.
        /// </summary>
        public string Platform { get; set; } = "web";

        /// <summary>
        /// Chrome / Edge / Firefox / Safari (opcional)
        /// </summary>
        public string? Browser { get; set; }

        /// <summary>
        /// Alias amigable: "PC Secretaría", "Celular", etc. (opcional)
        /// </summary>
        public string? DeviceName { get; set; }

        public bool PwaInstalled { get; set; }

        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Última vez que este token fue visto/actualizado por la app.
        /// Guardar en UTC.
        /// </summary>
        public DateTimeOffset LastSeenUtc { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset CreatedUtc { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedUtc { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// Si el token queda inválido, lo marcamos como revocado.
        /// </summary>
        public DateTimeOffset? RevokedUtc { get; set; }

        public int FailureCount { get; set; }
        public DateTimeOffset? LastFailureUtc { get; set; }

        // Navegación (si tu entidad Usuario existe, enlazala aquí)
         public Usuario User { get; set; } = default!;

        public ICollection<NotificationLog> NotificationLogs { get; set; } = new List<NotificationLog>();
    }
}
