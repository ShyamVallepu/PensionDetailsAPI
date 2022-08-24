using Pensioner_Details.Repository;

namespace Pensioner_Details.Provider
{

    public class DetailsProvider : IDetailsProvider
    {
      
        private IPensionerdetail detail;

        public PensionerDetail GetDetailsByAadhar(string aadhar)
        {
            detail = new PensionerRepository();
            PensionerDetail pensioner = detail.PensionerDetailByAadhar(aadhar);
            return pensioner;
        }

    }
}
