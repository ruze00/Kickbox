using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // FormExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcForm BeginForm(this AjaxHelper ajaxHelper,
                                        string actionName = null,
                                        string controllerName = null,
                                        object routeValues = null,
                                        FormMethod method = FormMethod.Post,
                                        string accept = null,
                                        string acceptCharset = null,
                                        string cssClass = null,
                                        string dir = null,
                                        string encType = null,
                                        string id = null,
                                        string lang = null,
                                        string name = null,
                                        string style = null,
                                        string title = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcForm BeginRouteForm(this AjaxHelper ajaxHelper,
                                             string routeName,
                                             RouteValueDictionary routeValues = null,
                                             FormMethod method = FormMethod.Post,
                                             string accept = null,
                                             string acceptCharset = null,
                                             string cssClass = null,
                                             string dir = null,
                                             string encType = null,
                                             string id = null,
                                             string lang = null,
                                             string name = null,
                                             string style = null,
                                             string title = null)
        {
            throw new NotImplementedException();
        }

        public static void EndForm(this AjaxHelper ajaxHelper)
        {
            throw new NotImplementedException();
        }
    }
}