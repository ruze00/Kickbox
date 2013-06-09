using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // TextAreaExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString TextArea(this AjaxHelper ajaxHelper,
                                             string name,
                                             string value = null,
                                             string accessKey = null,
                                             string cssClass = null,
                                             int? cols = null,
                                             string dir = null,
                                             bool disabled = false,
                                             string id = null,
                                             string lang = null,
                                             bool readOnly = false,
                                             int? rows = null,
                                             string style = null,
                                             int? tabIndex = null,
                                             string title = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString TextAreaFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                   Expression<Func<TModel, TProperty>> expression,
                                                                   string accessKey = null,
                                                                   string cssClass = null,
                                                                   int? cols = null,
                                                                   string dir = null,
                                                                   bool disabled = false,
                                                                   string id = null,
                                                                   string lang = null,
                                                                   bool readOnly = false,
                                                                   int? rows = null,
                                                                   string style = null,
                                                                   int? tabIndex = null,
                                                                   string title = null)
        {
            throw new NotImplementedException();
        }
    }
}