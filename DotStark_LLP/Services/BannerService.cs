using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class BannerService
    {
        public IEnumerable<BannerItemViewModel> GetBanners()
        {
            return DocumentHelper.GetDocuments<BannerItem>().AddColumns("BannerItemHeader", "BannerItemImage")
                .TopN(10).Select(x => new BannerItemViewModel
                {
                    Header = x.Fields.Header,
                    Image = x.Fields.Image
                });
        }

        public IEnumerable<HomeExViewModel> GetHomeEx()
        {
            return DocumentHelper.GetDocuments<HomeExp>().AddColumns("HomeExpHeader1", "HomeExpHeader2", 
                "HomeExpKenticoD", "HomeExpKenticoD1", "HomeExpCloudD",
                "HomeExpCloudD1", "HomeExpMigrationE", "HomeExpMigrationE1", "HomeExpConsulting",
                "HomeExpConsulting1", "HomeExpWhatClient", "HomeExpWeRespect", "HomeExpWorked",
                "HomeExpDirector", "HomeExpDotStark", "HomeExpManager")
                .TopN(10).Select(x => new HomeExViewModel
                {
                    Header1 = x.Fields.Header1,
                    Header2 = x.Fields.Header2,
                    KenticoD = x.Fields.KenticoD,
                    KenticoD1 = x.Fields.KenticoD1,
                    CloudD = x.Fields.CloudD,
                    CloudD1 = x.Fields.CloudD1,
                    MigrationE = x.Fields.MigrationE,
                    MigrationE1 = x.Fields.MigrationE1,
                    Consulting = x.Fields.Consulting,
                    Consulting1 = x.Fields.Consulting1,
                    WhatClient = x.Fields.WhatClient,
                    WeRespect = x.Fields.WeRespect,
                    Worked = x.Fields.Worked,
                    Director = x.Fields.Director,
                    DotStark = x.Fields.DotStark,
                    Manager = x.Fields.Manager
                    //Header3 = x.Fields.Header3,
                    //Header4 = x.Fields.Header4
                });

        }
    }
}