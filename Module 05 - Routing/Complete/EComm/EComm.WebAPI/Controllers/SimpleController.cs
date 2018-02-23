using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EComm.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class SimpleController : Controller
    {
        public IConfiguration Configuration { get; }
        public SimpleController(IConfiguration configuration)
        {
            Configuration = configuration;

            Console.WriteLine("********* SimpleController *******************");
            Console.WriteLine(String.Format("ConnectionStrings:DefaultConnection {0}",
                 Configuration["ConnectionStrings:DefaultConnection"]));
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return String.Format("id = {0}", id);
        }
    }
}