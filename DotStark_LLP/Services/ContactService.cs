using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models.Contact;
using DotStark_LLP.Models.ImageFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class ContactService
    {
        public IEnumerable<ContactViewModel> GetContacts()
        {
            return DocumentHelper.GetDocuments<Contact>().AddColumns("ContactPhone", "ContactEmail",
                "ContactOurLocation", "ContactConsider", "ContactDevelopment", "ContactCountryName", "ContactAddress",
                "ContactBanner", "ContactImgPen")
                .TopN(10).Select(x => new ContactViewModel
                {
                    Phone = x.Fields.Phone,
                    Email = x.Fields.Email,
                    OurLocation = x.Fields.OurLocation,
                    Consider = x.Fields.Consider,
                    Development = x.Fields.Development,
                    CountryName = x.Fields.CountryName,
                    Address = x.Fields.Address,
                    Banner = x.Fields.Banner,
                    ImgPen = x.Fields.ImgPen
                });
        }

        public IEnumerable<ImageItemViewModel> GetImages()
        {
            return DocumentHelper.GetDocuments<ImageItem>().AddColumns("ImageItemBanner", "ImageItemImgPen")
                .TopN(10).Select(x => new ImageItemViewModel
                {
                    Banner = x.Fields.Banner,
                    ImgPen = x.Fields.ImgPen
                });
        }
    }
}