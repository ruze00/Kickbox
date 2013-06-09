using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // RenderPartialExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static void RenderPartial(this AjaxHelper ajaxHelper,
                                         string partialViewName,
                                         object model = null,
                                         ViewDataDictionary viewData = null)
        {
            throw new NotImplementedException();
        }

    }
}