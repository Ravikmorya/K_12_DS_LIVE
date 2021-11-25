using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
//using DotStark_LLP.Models;
using DotStark_LLP.Models.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class StoryService
    {
        public IEnumerable<StoryViewModel> GetStorys()
        {
            //return DocumentHelper.Get
            return DocumentHelper.GetDocuments<StorySection>().AddColumns("StorySectionImage", "StorySectionHeading",
                "StorySectionText", "StorySectionText1", "StorySectionText2", "StorySectionText3",
                "StorySectionText4", "StorySectionText5")
                .TopN(10).Select(x => new StoryViewModel
                {
                    Heading = x.Fields.Heading,
                    Text = x.Fields.Text,
                    Text1 = x.Fields.Text1,
                    Image = x.Fields.Image,
                    Text2 = x.Fields.Text2,
                    Text3 = x.Fields.Text3,
                    Text4 = x.Fields.Text4,
                    Text5 = x.Fields.Text5
                });
        }
    }
}