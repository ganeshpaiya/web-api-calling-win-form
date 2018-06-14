using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calling_winform_in_webapi.Models
{
    public class Details
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone{ get; set; }
        public int Id { get; internal set; }
    }
}