using DotStark_LLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<BannerItemViewModel> Banners { get; set; }
        public IEnumerable<HomeItemViewModel> HomeItems { get; set; }
        public IEnumerable<HomeExViewModel> HomeExs { get; set; }
    }
}