using GCSTemplateExample.Service;
using Microsoft.AspNetCore.Mvc;

namespace GCSTemplateExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GcsController:Controller
    {
        private readonly IGcsService _service;
        private readonly IPintGcs _printService;

        public GcsController(IGcsService service, IPintGcs printService)
        {
            _service = service;
            _printService = printService;
        }
        [HttpPost]
        public async Task<IActionResult> AddGcs()
        {
           var data= _service.AddGcs();
            return Ok(data);
        }
        [HttpGet]
        public async Task<object> GetGcs()
        {
            var data= await _service.GetGcs();
            return Ok(data);
        }

        [HttpGet("print")]
        public async Task<IActionResult> Print()
        {
            var htmlString = await TemplateGenerator.GetKPIDetailsPDFHTMLString();
            var pdfContent = _printService.CreatePdf(htmlString);

            var stream = new MemoryStream(pdfContent);
            return new FileStreamResult(stream, "application/pdf");
        }
    }
}
