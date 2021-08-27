using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ProductOrdering.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController//Controller
    {
        [HttpGet]
        [Route("[action]")]
        public string Index()
        {
            return "Ok";
            //return View();
        }
    }
}
