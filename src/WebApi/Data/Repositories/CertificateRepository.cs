using WebApi.Data.Models;
using WebApi.Data.Models.DTO;

namespace WebApi.Data.Repositories
{
    public class CertificateRepository : ICertificateRepository
    {
        private CertificateDbContext _certificateContext;

        public CertificateRepository(CertificateDbContext certificateContext)
        {
            _certificateContext = certificateContext;
        }

        public async Task<Certificate> Create(CertificateDto certificateDto)
        {


            await _certificateContext.Certificates.Add(certificateDto);
        }

        public Certificate GetCertificate(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Certificate> GetCertificateList()
        {
            throw new NotImplementedException();
        }
    }
}
