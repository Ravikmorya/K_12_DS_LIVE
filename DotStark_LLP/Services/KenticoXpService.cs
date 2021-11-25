using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models.KenticoXp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class KenticoXpService
    {
        public IEnumerable<KenticoXpViewModel> GetKenticos()
        {
            return DocumentHelper.GetDocuments<KenticoSection>().AddColumns
                ("KenticoSectionKenticoFeaturesImage", "KenticoSectionBanner", "KenticoSectionKenticoXperience", "KenticoSectionKenticoFeatures", 
                "KenticoSectionContentManagement", "KenticoSectionScalability", "KenticoSectionWhatWe", "KenticoSectionWhatWe",
                "KenticoSectionHireCertifiedImg", "KenticoSectionDotImage")
                .TopN(50).Select(x => new KenticoXpViewModel
                {
                    Banner = x.Fields.Banner,
                    KenticoXperience = x.Fields.KenticoXperience,
                    KenticoFeatures = x.Fields.KenticoFeatures,
                    ContentManagement = x.Fields.ContentManagement,
                    Scalability = x.Fields.Scalability,
                    KenticoFeaturesImage = x.Fields.KenticoFeaturesImage,
                    HireCertified = x.Fields.HireCertified,
                    HireCertifiedImg = x.Fields.HireCertifiedImg,
                    WhatWe = x.Fields.WhatWe,
                    DotImage = x.Fields.DotImage
                });
        }
    }

}