using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models.Strengths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class StrengthsService
    {
        public IEnumerable<StrengthViewModel> GetStrengths()
        {
            return DocumentHelper.GetDocuments<StrengthsSection>().AddColumns("StrengthsHeading", "StrengthsHeading1",
                "StrengthsFile", "StrengthsText")
                .TopN(10).Select(x => new StrengthViewModel
                {
                    Heading = x.Fields.StrengthsHeading,
                    Heading1 = x.Fields.StrengthsHeading1,
                    Text = x.Fields.StrengthsText,
                    File = x.Fields.StrengthsFile
                });   
        }
    }
}