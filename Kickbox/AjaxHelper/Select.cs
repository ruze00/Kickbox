using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxHelperExtensions
    {
        // SelectExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString DropDownList(this AjaxHelper ajaxHelper,
                                                 string name,
                                                 IEnumerable<SelectListItem> selectList = null,
                                                 string optionLabel = null,
                                                 string cssClass = null,
                                                 string dir = null,
                                                 bool disabled = false,
                                                 string id = null,
                                                 string lang = null,
                                                 int? size = null,
                                                 string style = null,
                                                 int? tabIndex = null,
                                                 string title = null,
                                                 string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            if (dataBind == null)
                dataBind = "value: " + name;
            return htmlHelper.DropDownList(
                name,
                selectList,
                optionLabel,
                SelectAttributes(cssClass, dir, disabled, id, lang, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                       Expression<Func<TModel, TProperty>> expression,
                                                                       IEnumerable<SelectListItem> selectList = null,
                                                                       string optionLabel = null,
                                                                       string cssClass = null,
                                                                       string dir = null,
                                                                       bool disabled = false,
                                                                       string id = null,
                                                                       string lang = null,
                                                                       int? size = null,
                                                                       string style = null,
                                                                       int? tabIndex = null,
                                                                       string title = null,
                                                                       string dataBind = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);

            if (dataBind == null)
                dataBind = "value: " + name;

            return htmlHelper.DropDownList(
                name,
                selectList,
                optionLabel,
                SelectAttributes(cssClass, dir, disabled, id, lang, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString ListBox(this AjaxHelper ajaxHelper,
                                            string name,
                                            IEnumerable<SelectListItem> selectList = null,
                                            string cssClass = null,
                                            string dir = null,
                                            bool disabled = false,
                                            string id = null,
                                            string lang = null,
                                            int? size = null,
                                            string style = null,
                                            int? tabIndex = null,
                                            string title = null,
                                            string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "value: " + name;
            return htmlHelper.ListBox(
                name,
                selectList,
                SelectAttributes(cssClass, dir, disabled, id, lang, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString ListBoxFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                  Expression<Func<TModel, TProperty>> expression,
                                                                  IEnumerable<SelectListItem> selectList = null,
                                                                  string cssClass = null,
                                                                  string dir = null,
                                                                  bool disabled = false,
                                                                  string id = null,
                                                                  string lang = null,
                                                                  int? size = null,
                                                                  string style = null,
                                                                  int? tabIndex = null,
                                                                  string title = null,
                                                                  string dataBind = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);
            if (dataBind == null)
                dataBind = "value: " + name;
            return htmlHelper.ListBoxFor(
                expression,
                selectList,
                SelectAttributes(cssClass, dir, disabled, id, lang, size, style, tabIndex, title, dataBind));
        }
    }
}