using BookingContactDetails.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingContactDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingInfoController : ControllerBase
    {

      
        [HttpGet]
        public IEnumerable<BookingContactInformation> Get()
        {
            BookingContactInformation obj1 = new BookingContactInformation();
            BookingContactInformation obj2 = new BookingContactInformation();
            obj1.UserName = "Jeni";
            obj1.PhoneNo = 12345;
            obj1.Location = "chennai";
            obj1.EmailId = "abc@gmail.com";

            obj2.UserName = "Mira";
            obj2.PhoneNo = 67890;
            obj2.Location = "cochin";
            obj2.EmailId = "def@gmail.com";

            List<BookingContactInformation> lsobj = new List<BookingContactInformation>
            {
                obj1,obj2
            };

            return lsobj;


        }
    }
}
