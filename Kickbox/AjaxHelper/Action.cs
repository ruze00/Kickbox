using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static class ChildActionExtensions
    {
        // ChildActionExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString Action(this AjaxHelper ajaxHelper,
                                           string actionName,
                                           string controllerName = null,
                                           object routeValues = null)
        {
            return ajaxHelper.GetHtmlHelper().Action(actionName, controllerName, routeValues);
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static void RenderAction(this AjaxHelper ajaxHelper,
                                        string actionName,
                                        string controllerName = null,
                                        object routeValues = null)
        {
            throw new NotImplementedException();
        }
    }
}