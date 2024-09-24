using WebApi.Data.Models;
using WebApi.Data.Models.DTO;

namespace WebApi.Services
{
    public interface ICertificateService
    {
        Task<Certificate> AddCertificate(CertificateDto certificateDto);
    }
}
