using DotStark_LLP.Models.ImageFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Contact
{
    public class IndexViewModel
    {
        public IEnumerable<ContactViewModel> Contacts { get; set; }
        public IEnumerable<ImageItemViewModel> Images { get; set; }
    }
}