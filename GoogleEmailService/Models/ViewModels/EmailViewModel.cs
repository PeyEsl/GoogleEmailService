namespace GoogleEmailService.Models
{
    public class EmailViewModel
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Text { get; set; }
        public string? CallBackUrl { get; set; }
    }
}
