namespace InstitutoServices.DTOs
{
    public sealed class SendTestNotificationResponse
    {
        public string MessageId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string TokenPreview { get; set; } = string.Empty;
    }
}
