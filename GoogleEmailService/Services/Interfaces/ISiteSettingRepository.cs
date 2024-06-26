using GoogleEmailService.Models.Entities;

namespace GoogleEmailService.Services.Interfaces
{
    public interface ISiteSettingRepository
    {
        EmailSetting GetDefaultEmail();
    }
}
