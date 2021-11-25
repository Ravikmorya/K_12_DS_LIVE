using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models
{
    public class ServiceViewModel
    {
        public string Text1 { get; set; }
        public DocumentAttachment TextImage1 { get; set; }
        public string Text2 { get; set; }
        public DocumentAttachment TextImage2 { get; set; }
        public string Text3 { get; set; }
        public DocumentAttachment TextImage3 { get; set; }
		public string Text4 { get; set; }
		public DocumentAttachment TextImage4 { get; set; }
		public string Text5 { get; set; }
		public DocumentAttachment TextImage5 { get; set; }
		public string Text6 { get; set; }
		public DocumentAttachment TextImage6 { get; set; }
		public DocumentAttachment TextImage { get; set; }       
        //public Guid NodeGUID { get; set; }
        //public string NodeAlias { get; set; }
    }
}