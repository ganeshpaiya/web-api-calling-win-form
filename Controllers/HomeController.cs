using Calling_winform_in_webapi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calling_winform_in_webapi.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/Home/GetCustomers")]
        [HttpPost]
        public List<Details> GetCustomers()

        {
            using (TestDBEntities1 md=new TestDBEntities1())
         
            {
                return md.Tables.Select(pe => new Details
                { 
                    Id=pe.Id,
                    Name =pe.Name,
                    Address =pe.Address,
                    Phone = (int)pe.Phone
                }).ToList();

            }
        }


        //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html")); 

    }
}
