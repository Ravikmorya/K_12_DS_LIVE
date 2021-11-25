using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Story
{
    public class IndexViewModel
    {
        public IEnumerable<StoryViewModel> Storys { get; set; }
    }
}