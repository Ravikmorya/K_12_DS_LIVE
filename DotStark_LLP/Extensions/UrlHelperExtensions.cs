using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Kentico.Web.Mvc;
using System.Web.Http.Routing;
using UrlHelper = System.Web.Mvc.UrlHelper;
using Kentico.Content.Web.Mvc.Routing;

namespace DotStark_LLP.Extensions
{
    public static class UrlHelperExtensions
    {

        public static string ForArticle(this UrlHelper urlHelper, Guid nodeGuid, string nodeAlias)
        {
            return urlHelper.Action("Show", "Service", new
            {
                guid = nodeGuid,
                pageAlias = nodeAlias
            });
        }
        /// <summary>
        /// Returns canonical URL of current page.
        /// </summary>
        /// <param name="urlHelper">URL Helper</param>
        public static string CanonicalUrl(this UrlHelper urlHelper)
        {
            var pageMainUrl = urlHelper.Kentico().PageMainUrl();
            var currentUrl = urlHelper.RequestContext.HttpContext.Request.Url;

            if (String.IsNullOrEmpty(pageMainUrl))
            {
                return currentUrl.GetLeftPart(UriPartial.Path).TrimEnd('/');
            }

            return new Uri(
                new Uri(currentUrl.GetLeftPart(UriPartial.Authority)),
                urlHelper.Content(pageMainUrl)
                ).AbsoluteUri.TrimEnd('/');
        }
    }
}