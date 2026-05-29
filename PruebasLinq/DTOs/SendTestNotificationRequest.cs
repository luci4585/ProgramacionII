namespace InstitutoServices.DTOs
{
    public sealed class SendTestNotificationRequest
    {
        public string FcmToken { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
