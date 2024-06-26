namespace GoogleEmailService.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(string to, string subject, string body);
    }
}
