using System.Collections.Generic;

namespace Pensioner_Details.Repository
{
    public interface IPensionerdetail
    {
        public PensionerDetail PensionerDetailByAadhar(string aadhar);
        public List<PensionerDetail> GetDetailsCsv();

    }
}
