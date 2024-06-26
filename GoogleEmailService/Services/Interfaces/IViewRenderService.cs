namespace GoogleEmailService.Services.Interfaces
{
    public interface IViewRenderService
    {
        Task<string> RenderToStringAsync(string viewName, object model);
    }
}
