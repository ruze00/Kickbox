using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // EditorExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString Editor(this AjaxHelper ajaxHelper,
                                           string expression,
                                           string templateName = null,
                                           string htmlFieldName = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString EditorFor<TModel, TValue>(this AjaxHelper<TModel> ajaxHelper,
                                                              Expression<Func<TModel, TValue>> expression,
                                                              string templateName = null,
                                                              string htmlFieldName = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString EditorForModel(this AjaxHelper ajaxHelper,
                                                   string templateName = null,
                                                   string htmlFieldName = null)
        {
            throw new NotImplementedException();
        }
    }
}