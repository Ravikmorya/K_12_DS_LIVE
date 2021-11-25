using DotStark_LLP.Models.ImageFolder;
using DotStark_LLP.Models.ImageMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.KenticoXp
{
    public class IndexViewModel
    {
        public IEnumerable<KenticoXpViewModel> KenticoXp { get; set; }
        public IEnumerable<ImageViewModel> Images { get; set; }
    }
}