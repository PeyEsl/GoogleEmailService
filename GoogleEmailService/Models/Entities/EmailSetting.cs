namespace GoogleEmailService.Models.Entities
{
    public class EmailSetting
    {
        public int Id { get; set; }
        public string? From { get; set; }
        public string? Password { get; set; }
        public string? SMTP { get; set; }
        public bool EnableSSL { get; set; }
        public string? DisplayName { get; set; }
        public int Port { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
