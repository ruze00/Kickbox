using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // LinkExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper,
                                               string linkText,
                                               string actionName,
                                               string controllerName = null,
                                               string protocol = null,
                                               string hostName = null,
                                               string fragment = null,
                                               object routeValues = null,
                                               string accessKey = null,
                                               string charset = null,
                                               string coords = null,
                                               string cssClass = null,
                                               string dir = null,
                                               string hrefLang = null,
                                               string id = null,
                                               string lang = null,
                                               string name = null,
                                               string rel = null,
                                               string rev = null,
                                               string shape = null,
                                               string style = null,
                                               string target = null,
                                               string title = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString RouteLink(this AjaxHelper ajaxHelper,
                                              string linkText,
                                              string routeName,
                                              string protocol = null,
                                              string hostName = null,
                                              string fragment = null,
                                              object routeValues = null,
                                              string accessKey = null,
                                              string charset = null,
                                              string coords = null,
                                              string cssClass = null,
                                              string dir = null,
                                              string hrefLang = null,
                                              string id = null,
                                              string lang = null,
                                              string name = null,
                                              string rel = null,
                                              string rev = null,
                                              string shape = null,
                                              string style = null,
                                              string target = null,
                                              string title = null)
        {
            throw new NotImplementedException();
        }

    }
}