using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class HomeItemService
    {
        public IEnumerable<HomeItemViewModel> GetHomeItems()
        {
            return DocumentHelper.GetDocuments<HomeItem>().AddColumns("HomeItemHead1", "HomeItemHead2", "HomeItemHead3", 
                "HomeItemRISEON", "HomeItemSTARK", "HomeItemWhatsgoing", "HomeItemKenticoExperts", "HomeItemPartner",
                "HomeItemExplorePossibilities", "HomeItemSpeak", "HomeItemXperience", "HomeItemKenticoC",
                "HomeItemKenticoBro", "HomeItemLinkText", "HomeItemLink")
                .TopN(10).Select(x => new HomeItemViewModel
                {
                    Head1 = x.Fields.Head1,
                    Head2 = x.Fields.Head2,
                    Head3 = x.Fields.Head3,
                    RISEON = x.Fields.RISEON,
                    STARK = x.Fields.STARK,
                    Whatsgoing = x.Fields.Whatsgoing,
                    KenticoExperts = x.Fields.KenticoExperts,
                    Partner = x.Fields.Partner,
                    Speak = x.Fields.Speak,
                    ExplorePossibilities = x.Fields.ExplorePossibilities,
                    Xperience = x.Fields.Xperience,
                    KenticoC = x.Fields.KenticoC,
                    KenticoBro = x.Fields.KenticoBro,
                    ReadMoreText = x.Fields.LinkText,
                    //ReadMorePage = x.Fields.Link.FirstOrDefault()?.RelativeURL
                    ReadMorePage = x.Fields.Link.FirstOrDefault().RelativeURL

                });          
        }       
    }
}