using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Routing;
using Kentico.Web.Mvc;
using System.Web.Mvc;

namespace DotStark_LLP.Extensions
{
    public static class UrlExtensions
    {
        [System.Obsolete]
        public static string KenticoImageUrl(this System.Web.Mvc.UrlHelper helper, string path)
        {
            return helper.Kentico().ImageUrl(path, SizeConstraint.Empty);

        }
    }
}