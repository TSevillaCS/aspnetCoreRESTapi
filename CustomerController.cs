using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("/displayCustomers")]
    [ApiController]

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return CustomerService.GetCustomers();
        }
    }
}
