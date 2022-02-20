using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW5.Models
{
    public class Image
    {
        public string Name { get; set; }
        public Guid ID { get; set; }
        public string Base64 { get; set; }
    }
}