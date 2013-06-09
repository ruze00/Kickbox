using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxExtensions
    {
        // ValidationExtensions

        public static void Validate(this AjaxHelper ajaxHelper, string modelName)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        public static void ValidateFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                          Expression<Func<TModel, TProperty>> expression)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames", MessageId = "2#",
            Justification = "This API has already shipped.")]
        public static MvcHtmlString ValidationMessage(this AjaxHelper ajaxHelper,
                                                      string modelName,
                                                      string validationMessage = null,
                                                      string cssClass = null,
                                                      string dir = null,
                                                      string id = null,
                                                      string lang = null,
                                                      string style = null,
                                                      string title = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString ValidationMessageFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                            Expression<Func<TModel, TProperty>>
                                                                                expression,
                                                                            string validationMessage = null,
                                                                            string cssClass = null,
                                                                            string dir = null,
                                                                            string id = null,
                                                                            string lang = null,
                                                                            string style = null,
                                                                            string title = null)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString ValidationSummary(this AjaxHelper ajaxHelper,
                                                      string message = null,
                                                      bool excludePropertyErrors = false,
                                                      string cssClass = null,
                                                      string dir = null,
                                                      string id = null,
                                                      string lang = null,
                                                      string style = null,
                                                      string title = null)
        {
            throw new NotImplementedException();
        }
    }
}