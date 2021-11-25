using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Contact
{
    public class ContactViewModel
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OurLocation { get; set; }
        public string Consider { get; set; }
        public string Development { get; set; }
        public string CountryName { get; set; }
        public string Address { get; set; }
        public DocumentAttachment Banner { get; set; }
        public DocumentAttachment ImgPen { get; set; }
    }
}