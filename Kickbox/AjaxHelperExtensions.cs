// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace Microsoft.Web.Mvc.Html
{
    // This class contains definitions of single "super" HTML helper methods, which rely on
    // CLR 4's default values for method parameters to make them more consumable. Methods
    // which previously took an HTML attributes object/dictionary now have their legal
    // attribute values all available as optional parameters. Some attributes are only
    // applicable for some DTDs; deprecated attributes (like "align" on input) were
    // specifically excluded.
    //
    // Since htmlAttributes was very often the last parameter to HTML helper methods,
    // converting to these new syntaxes should be as simple as converting your anonymous
    // object htmlAttributes collections into optional parameters.
    //
    // Where there were two overloads for route values (anonymous object and dictionary),
    // there is only a single overload now, which takes type object. If what you pass is
    // a dictionary of the correct type, then we'll use that; otherwise, we'll assume it's
    // an anonymous object and create the dictionary for you. This should make it simple
    // to port methods using route values, as they should just continue to work as before. 
    //
    // Some HTML helpers did not take HTML attributes parameters. They are recreated here
    // so that the user does not have to import both System.Web.Mvc.Html as well as this
    // namespace, since the purpose of these methods is to get rid of all the overloads
    // for the built-in HTML helpers.
    //
    // The legal attribute values were derived from: http://www.w3schools.com/tags/

    public static partial class AjaxHelperExtensions
    {
        // Helper methods

        private static void AddOptional(this IDictionary<string, object> dictionary, string key, bool value)
        {
            if (value)
            {
                dictionary[key] = key;
            }
        }

        private static void AddOptional(this IDictionary<string, object> dictionary, string key, object value)
        {
            if (value != null)
            {
                dictionary[key] = value;
            }
        }

        private static IDictionary<string, object> Attributes(string cssClass,
                                                              string id,
                                                              string style,
                                                              string dataBind = null)
        {
            var htmlAttributes = new RouteValueDictionary();

            htmlAttributes.AddOptional("class", cssClass);
            htmlAttributes.AddOptional("id", id);
            htmlAttributes.AddOptional("style", style);
            htmlAttributes.AddOptional("data-bind", dataBind);

            return htmlAttributes;
        }

        private static IDictionary<string, object> AnchorAttributes(string accessKey,
                                                                    string charset,
                                                                    string coords,
                                                                    string cssClass,
                                                                    string dir,
                                                                    string hrefLang,
                                                                    string id,
                                                                    string lang,
                                                                    string name,
                                                                    string rel,
                                                                    string rev,
                                                                    string shape,
                                                                    string style,
                                                                    string target,
                                                                    string title)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("accesskey", accessKey);
            htmlAttributes.AddOptional("charset", charset);
            htmlAttributes.AddOptional("coords", coords);
            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("hreflang", hrefLang);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("name", name);
            htmlAttributes.AddOptional("rel", rel);
            htmlAttributes.AddOptional("rev", rev);
            htmlAttributes.AddOptional("shape", shape);
            htmlAttributes.AddOptional("target", target);
            htmlAttributes.AddOptional("title", title);

            return htmlAttributes;
        }

        private static IDictionary<string, object> FormAttributes(string accept,
                                                                  string acceptCharset,
                                                                  string cssClass,
                                                                  string dir,
                                                                  string encType,
                                                                  string id,
                                                                  string lang,
                                                                  string name,
                                                                  string style,
                                                                  string title)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("accept", accept);
            htmlAttributes.AddOptional("accept-charset", acceptCharset);
            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("enctype", encType);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("name", name);
            htmlAttributes.AddOptional("title", title);

            return htmlAttributes;
        }

        private static IDictionary<string, object> InputAttributes(string name,
                                                                   string cssClass,
                                                                   string dir,
                                                                   bool disabled,
                                                                   string id,
                                                                   string lang,
                                                                   int? maxLength,
                                                                   bool readOnly,
                                                                   int? size,
                                                                   string style,
                                                                   int? tabIndex,
                                                                   string title,
                                                                   string dataBind = null)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("disabled", disabled);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("maxlength", maxLength);
            htmlAttributes.AddOptional("readonly", readOnly);
            htmlAttributes.AddOptional("size", size);
            htmlAttributes.AddOptional("tabindex", tabIndex);
            htmlAttributes.AddOptional("title", title);
            htmlAttributes.AddOptional("data-bind", dataBind);

            return htmlAttributes;
        }

        private static IDictionary<string, object> SelectAttributes(string cssClass,
                                                                    string dir,
                                                                    bool disabled,
                                                                    string id,
                                                                    string lang,
                                                                    int? size,
                                                                    string style,
                                                                    int? tabIndex,
                                                                    string title,
                                                                    string dataBind = null)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("disabled", disabled);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("size", size);
            htmlAttributes.AddOptional("tabindex", tabIndex);
            htmlAttributes.AddOptional("title", title);
            htmlAttributes.AddOptional("data-bind", dataBind);

            return htmlAttributes;
        }

        private static IDictionary<string, object> SpanAttributes(string cssClass,
                                                                  string dir,
                                                                  string id,
                                                                  string lang,
                                                                  string style,
                                                                  string title)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("title", title);

            return htmlAttributes;
        }

        private static IDictionary<string, object> TextAreaAttributes(string accessKey,
                                                                      string cssClass,
                                                                      int? cols,
                                                                      string dir,
                                                                      bool disabled,
                                                                      string id,
                                                                      string lang,
                                                                      bool readOnly,
                                                                      int? rows,
                                                                      string style,
                                                                      int? tabIndex,
                                                                      string title)
        {
            IDictionary<string, object> htmlAttributes = Attributes(cssClass, id, style);

            htmlAttributes.AddOptional("accesskey", accessKey);
            htmlAttributes.AddOptional("cols", cols);
            htmlAttributes.AddOptional("dir", dir);
            htmlAttributes.AddOptional("disabled", disabled);
            htmlAttributes.AddOptional("lang", lang);
            htmlAttributes.AddOptional("readonly", readOnly);
            htmlAttributes.AddOptional("rows", rows);
            htmlAttributes.AddOptional("style", style);
            htmlAttributes.AddOptional("tabindex", tabIndex);
            htmlAttributes.AddOptional("title", title);

            return htmlAttributes;
        }

        public static HtmlHelper GetHtmlHelper(this AjaxHelper ajaxHelper)
        {
            return new HtmlHelper(ajaxHelper.ViewContext, ajaxHelper.ViewDataContainer, ajaxHelper.RouteCollection);
        }

        public static HtmlHelper<TModel> GetHtmlHelper<TModel>(this AjaxHelper<TModel> ajaxHelper)
        {
            return new HtmlHelper<TModel>(
                ajaxHelper.ViewContext, ajaxHelper.ViewDataContainer, ajaxHelper.RouteCollection);
        }
    }
}