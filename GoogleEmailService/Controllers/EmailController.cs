using GoogleEmailService.Models;
using GoogleEmailService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GoogleEmailService.Controllers
{
    public class EmailController : Controller
    {
        private readonly IViewRenderService _viewRenderService;
        private readonly IEmailService _emailService;

        public EmailController(IViewRenderService viewRenderService, IEmailService emailService)
        {
            _viewRenderService = viewRenderService;
            _emailService = emailService;
        }

        public IActionResult Index(EmailViewModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult SendEmail()
        {
            return View(new EmailViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailViewModel model)
        {
            try
            {
                string? callBackUrl = Url.ActionLink("Index", "Email", new { email = model.Email, text = model.Text! }, Request.Scheme);

                model.CallBackUrl = callBackUrl;

                string body = await _viewRenderService.RenderToStringAsync("_SendPage", model);

                _emailService.SendEmail(model.Email!, "Email Service", body);

                return RedirectToAction("Index", "Home", new { isSent = true });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
            }

            return View(model);
        }
    }
}
