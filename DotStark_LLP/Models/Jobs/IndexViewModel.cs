using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Jobs
{
    public class IndexViewModel
    {
        public IEnumerable<JobsViewModel> Jobs { get; set; }
    }
}