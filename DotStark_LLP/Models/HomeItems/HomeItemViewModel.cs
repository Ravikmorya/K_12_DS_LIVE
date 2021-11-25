using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models
{
    public class HomeItemViewModel
    {
        public string Head1 { get; set; }
        public string Head2 { get; set; }
        public string Head3 { get; set; }

        public string RISEON { get; set; }
        public string STARK { get; set; }
        public string Whatsgoing { get; set; }
        public string KenticoExperts { get; set; }
        public string Partner { get; set; }
        public string Speak { get; set; }
        public string ExplorePossibilities { get; set; }
        public DocumentAttachment Xperience { get; set; }
        public DocumentAttachment KenticoC { get; set; }
        public DocumentAttachment KenticoBro { get; set; }
        public string ReadMoreText { get; set; }
        public string ReadMorePage { get; set; }

        //public static HomeItemViewModel GetViewModel(HomeItem homeItem)
        //{
        //    return homeItem == null ? null : new HomeItemViewModel
        //    {
                
        //        ReadMorePage = homeItem.Fields.Link.FirstOrDefault()?.RelativeURL
        //    };
        //}


    }
}