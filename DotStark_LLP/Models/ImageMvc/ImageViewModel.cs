using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.ImageMvc
{
	public class ImageViewModel
	{
		public string BuildText { get; set; }
		public DocumentAttachment Build { get; set; }
		public DocumentAttachment FooterImg { get; set; }
	}
}