using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models.ImageMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
	public class ImageMvcService
	{
        public IEnumerable<ImageViewModel> GetImages()
        {
            return DocumentHelper.GetDocuments<ImageMvc>().AddColumns("ImageMvcBuild", "ImageMvcBuildText", "ImageMvcFooterImg")
                .TopN(10).Select(x => new ImageViewModel
                {
                    BuildText = x.Fields.BuildText,
                    Build = x.Fields.Build,
                    FooterImg = x.Fields.FooterImg
                });
        }
    }
}