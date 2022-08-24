using Microsoft.AspNetCore.Mvc;
using Pensioner_Details.Provider;

namespace Pensioner_Details.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensionerDetailController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(PensionerDetailController));
        private IDetailsProvider detail;

        public PensionerDetailController(IDetailsProvider _Idetail)
        {
            detail = _Idetail;
        }
        ///Getting the details of the pensioner details from csv file by giving Aadhar Number
        ///Summary
        /// <returns> pensioner Values</returns>
         
        // GET: api/PensionerDetail/5
        [HttpGet("{aadhar}")]
        public IActionResult PensionerDetailByAadhar(string aadhar)
        {
            detail = new DetailsProvider();
            PensionerDetail pensioner = detail.GetDetailsByAadhar(aadhar);
            if (pensioner==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(pensioner);
            }
        }


    }
}

