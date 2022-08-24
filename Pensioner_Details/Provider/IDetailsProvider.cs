namespace Pensioner_Details.Provider
{
    public interface IDetailsProvider
    {
        public PensionerDetail GetDetailsByAadhar(string aadhar);
    }
}
