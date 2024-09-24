using WebApi.Data.Models;
using WebApi.Data.Models.DTO;

namespace WebApi.Data.Repositories
{
    public interface ICertificateRepository
    {
        IEnumerable<Certificate> GetCertificateList();
        Certificate GetCertificate(int id);
        void Create(CertificateDto certificate);
    }
}
