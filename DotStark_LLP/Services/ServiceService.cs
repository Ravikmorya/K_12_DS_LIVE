using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class ServiceService
    {
        public IEnumerable<ServiceViewModel> GetServiss()
        {
            return DocumentHelper.GetDocuments<ServicesSection>().AddColumns("ServicesSectionText1", "ServicesSectionTextImage",
                "ServicesSectionTextImage1", "ServicesSectionText2", "ServicesSectionTextImage2"
                ,"ServicesSectionText3", "ServicesSectionTextImage3",
                "ServicesSectionText4", "ServicesSectionTextImage4",
                "ServicesSectionText5", "ServicesSectionTextImage5",
                "ServicesSectionText6", "ServicesSectionTextImage6")
                .TopN(15).Select(x => new ServiceViewModel
                {
                    Text1 = x.Fields.Text1,
                    Text2 = x.Fields.Text2,
                    Text3 = x.Fields.Text3,
					Text4 = x.Fields.Text4,
					Text5 = x.Fields.Text5,
					Text6 = x.Fields.Text6,
					TextImage = x.Fields.TextImage,
                    TextImage1 = x.Fields.TextImage1,
                    TextImage2 = x.Fields.TextImage2,
                    TextImage3 = x.Fields.TextImage3,

					TextImage4 = x.Fields.TextImage4,
					TextImage5 = x.Fields.TextImage5,
					TextImage6 = x.Fields.TextImage6
				});
        }
    }
}