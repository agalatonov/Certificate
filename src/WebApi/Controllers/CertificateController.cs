using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Models;
using WebApi.Data.Models.DTO;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificateController : ControllerBase
    {
        private ICertificateService _certificateService;
        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Certificate), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] CertificateDto certificateDto)
        {
            var result = await _certificateService.AddCertificate(certificateDto);

            return Ok(result);
        }
    }
}
