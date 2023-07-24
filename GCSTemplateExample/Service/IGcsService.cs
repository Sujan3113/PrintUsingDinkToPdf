namespace GCSTemplateExample.Service
{
    public interface IGcsService
    {
        Task<string> AddGcs();
        Task<object> GetGcs();
        //byte[] CreatePdf(string htmlContent);
    }
}
