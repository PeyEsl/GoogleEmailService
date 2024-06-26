using GoogleEmailService.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GoogleEmailService.Data
{
    public class SeedData : IEntityTypeConfiguration<EmailSetting>
    {
        public void Configure(EntityTypeBuilder<EmailSetting> builder)
        {
            builder.HasData(new EmailSetting
            {
                Id = 1,
                DisplayName = "Email Service",
                From = "artan.co.5827@gmail.com",
                Password = "hvsssvjtdaeunevp",
                SMTP = "smtp.gmail.com",
                Port = 587,
                EnableSSL = true,
                IsDefault = true,
                IsDelete = false,
                CreateDate = DateTime.Now
            });
        }
    }
}
