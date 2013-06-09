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
        // InputExtensions

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString CheckBox(this AjaxHelper ajaxHelper,
                                             string name,
                                             bool? isChecked = null,
                                             string cssClass = null,
                                             string dir = null,
                                             bool disabled = false,
                                             string id = null,
                                             string lang = null,
                                             int? maxLength = null,
                                             bool readOnly = false,
                                             int? size = null,
                                             string style = null,
                                             int? tabIndex = null,
                                             string title = null,
                                             string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "checked: " + name;

            IDictionary<string, object> htmlAttributes = InputAttributes(
                name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind);

            return isChecked.HasValue
                       ? htmlHelper.CheckBox(name, isChecked.Value, htmlAttributes)
                       : htmlHelper.CheckBox(name, htmlAttributes);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString CheckBoxFor<TModel>(this AjaxHelper<TModel> ajaxHelper,
                                                        Expression<Func<TModel, bool>> expression,
                                                        string cssClass = null,
                                                        string dir = null,
                                                        bool disabled = false,
                                                        string id = null,
                                                        string lang = null,
                                                        int? maxLength = null,
                                                        bool readOnly = false,
                                                        int? size = null,
                                                        string style = null,
                                                        int? tabIndex = null,
                                                        string title = null,
                                                        string dataBind = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);

            if (dataBind == null)
                dataBind = "checked: " + name;

            return htmlHelper.CheckBoxFor(
                expression,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString Hidden(this AjaxHelper ajaxHelper,
                                           string name,
                                           object value = null,
                                           string cssClass = null,
                                           string id = null,
                                           string style = null,
                                           string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "value: " + name;

            return htmlHelper.Hidden(name, value, Attributes(cssClass, id, style, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString HiddenFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                 Expression<Func<TModel, TProperty>> expression,
                                                                 string cssClass = null,
                                                                 string id = null,
                                                                 string style = null,
                                                                 string dataBind = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);

            if (dataBind == null)
                dataBind = "value: " + name;

            return htmlHelper.HiddenFor(expression, Attributes(cssClass, id, style, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString Password(this AjaxHelper ajaxHelper,
                                             string name,
                                             object value = null,
                                             string cssClass = null,
                                             string dir = null,
                                             bool disabled = false,
                                             string id = null,
                                             string lang = null,
                                             int? maxLength = null,
                                             bool readOnly = false,
                                             int? size = null,
                                             string style = null,
                                             int? tabIndex = null,
                                             string title = null,
                                             string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "value: " + name;

            return htmlHelper.Password(
                name,
                value,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString PasswordFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                   Expression<Func<TModel, TProperty>> expression,
                                                                   string cssClass = null,
                                                                   bool disabled = false,
                                                                   string dir = null,
                                                                   string id = null,
                                                                   string lang = null,
                                                                   int? maxLength = null,
                                                                   bool readOnly = false,
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

            return htmlHelper.PasswordFor(
                expression,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString RadioButton(this AjaxHelper ajaxHelper,
                                                string name,
                                                object value,
                                                bool? isChecked = null,
                                                string cssClass = null,
                                                string dir = null,
                                                bool disabled = false,
                                                string id = null,
                                                string lang = null,
                                                int? maxLength = null,
                                                bool readOnly = false,
                                                int? size = null,
                                                string style = null,
                                                int? tabIndex = null,
                                                string title = null,
                                                string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "checked: " + name;

            IDictionary<string, object> htmlAttributes = InputAttributes(
                name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind);

            return isChecked.HasValue
                       ? htmlHelper.RadioButton(name, value, isChecked.Value, htmlAttributes)
                       : htmlHelper.RadioButton(name, value, htmlAttributes);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString RadioButtonFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                      Expression<Func<TModel, TProperty>> expression,
                                                                      object value,
                                                                      string cssClass = null,
                                                                      string dir = null,
                                                                      bool disabled = false,
                                                                      string id = null,
                                                                      string lang = null,
                                                                      int? maxLength = null,
                                                                      bool readOnly = false,
                                                                      int? size = null,
                                                                      string style = null,
                                                                      int? tabIndex = null,
                                                                      string title = null,
                                                                      string dataBind = null)
        {
            HtmlHelper<TModel> htmlHelper = ajaxHelper.GetHtmlHelper();
            string name = ExpressionHelper.GetExpressionText(expression);

            if (dataBind == null)
                dataBind = "checked: " + name;

            return htmlHelper.RadioButtonFor(
                expression,
                value,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString TextBox(this AjaxHelper ajaxHelper,
                                            string name,
                                            object value = null,
                                            string cssClass = null,
                                            string dir = null,
                                            bool disabled = false,
                                            string id = null,
                                            string lang = null,
                                            int? maxLength = null,
                                            bool readOnly = false,
                                            int? size = null,
                                            string style = null,
                                            int? tabIndex = null,
                                            string title = null,
                                            string dataBind = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();

            if (dataBind == null)
                dataBind = "value: " + name;

            return htmlHelper.TextBox(
                name,
                value,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is an appropriate nesting of generic types")]
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
            Justification = "The purpose of these helpers is to use default parameters to simplify common usage.")]
        public static MvcHtmlString TextBoxFor<TModel, TProperty>(this AjaxHelper<TModel> ajaxHelper,
                                                                  Expression<Func<TModel, TProperty>> expression,
                                                                  string cssClass = null,
                                                                  string dir = null,
                                                                  bool disabled = false,
                                                                  string id = null,
                                                                  string lang = null,
                                                                  int? maxLength = null,
                                                                  bool readOnly = false,
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

            return htmlHelper.TextBoxFor(
                expression,
                InputAttributes(
                    name, cssClass, dir, disabled, id, lang, maxLength, readOnly, size, style, tabIndex, title, dataBind));
        }
    }
}