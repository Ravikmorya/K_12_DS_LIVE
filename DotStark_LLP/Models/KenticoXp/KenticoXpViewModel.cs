using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.KenticoXp
{
    public class KenticoXpViewModel
    {
        public DocumentAttachment Banner { get; set; }
        public string KenticoXperience { get; set; }
        public string KenticoFeatures { get; set; }
        public string ContentManagement { get; set; }
        public string Scalability { get; set; }
        public DocumentAttachment KenticoFeaturesImage { get; set; }
        public string HireCertified { get; set; }
        public DocumentAttachment HireCertifiedImg { get; set; }
        public string WhatWe { get; set; }
        public DocumentAttachment DotImage { get; set; }



    }
}