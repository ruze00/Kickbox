using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxHelperExtensions
    {
        // DisplayExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString Display(this AjaxHelper ajaxHelper,
                                            string expression,
                                            string templateName = null,
                                            string htmlFieldName = null,
                                            string dataBind = null,
                                            string wrapperTag = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);
            if (dataBind == null)
                dataBind = "text: " + name;
            if (wrapperTag == null)
                wrapperTag = "span";
            return
                MvcHtmlString.Create(
                    string.Format(
                        "<{0}  data-bind=\"{1}\">{2}</{0}>", wrapperTag, dataBind, htmlHelper.Display(expression)));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString DisplayFor<TModel, TValue>(this AjaxHelper<TModel> ajaxHelper,
                                                               Expression<Func<TModel, TValue>> expression,
                                                               string templateName = null,
                                                               string htmlFieldName = null,
                                                               string dataBind = null,
                                                               string wrapperTag = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);
            if (dataBind == null)
                dataBind = "text: " + name;
            if (wrapperTag == null)
                wrapperTag = "span";
            return
                MvcHtmlString.Create(
                    string.Format(
                        "<{0}  data-bind=\"{1}\">{2}</{0}>", wrapperTag, dataBind, htmlHelper.DisplayFor(expression)));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString DisplayForModel(this AjaxHelper ajaxHelper,
                                                    string templateName = null,
                                                    string htmlFieldName = null,
                                                    string dataBind = null)
        {
            //todo See what to do with that 
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            return htmlHelper.DisplayForModel(templateName, htmlFieldName);
        }

        // DisplayTextExtensions

        public static MvcHtmlString DisplayText(this AjaxHelper ajaxHelper,
                                                string name,
                                                string dataBind = null,
                                                string wrapperTag = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            if (dataBind == null)
                dataBind = "text: " + name;
            if (wrapperTag == null)
                wrapperTag = "span";
            return
                MvcHtmlString.Create(
                    string.Format(
                        "<{0}  data-bind=\"{1}\">{2}</{0}>", wrapperTag, dataBind, htmlHelper.DisplayText(name)));
        }
    }
}