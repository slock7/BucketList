using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BucketList.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "some phone";
        }

        [Route("[action]")]
        public string Address()
        {
            return "some address";
        }
    }
}