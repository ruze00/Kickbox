using System;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Kickbox.JsonHelper;
using Newtonsoft.Json;

namespace Microsoft.Web.Mvc.Html
{
    public static partial class AjaxHelperExtensions
    {
        public static MvcHtmlString MapModelToKnockout(this AjaxHelper ajaxHelper, object model = null)
        {
            if (model == null)
                model = ajaxHelper.ViewData.Model;

            Type type = model.GetType();
            string name = type.Name;

            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("window.vm = ko.mapping.fromJS(" + ajaxHelper.GetHtmlHelper().Raw(model.ToJson()) + ");");
            sb.AppendLine("ko.applyBindings(window.vm);");

            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString EnableSubmit(this AjaxHelper ajaxHelper,
                                                 string formName,
                                                 string controller,
                                                 string processMethod = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("$('" + formName + "').submit(function (e) {");
            sb.AppendLine("\te.preventDefault();");
            sb.AppendLine("\t$.ajax({");
            sb.AppendLine(
                "\t\turl: '" + new UrlHelper(HttpContext.Current.Request.RequestContext).Action(controller) + "',");
            sb.AppendLine("\t\ttype: 'POST',");
            sb.AppendLine("\t\tdataType: 'json',");
            sb.AppendLine("\t\tdata: $(this).serialize(),");
            sb.AppendLine("\t\tsuccess: function (data) {");
            if (!String.IsNullOrEmpty(processMethod))
                sb.AppendLine("\t\t\t" + processMethod + "(data);");
            else
            {
                // default behavior
                sb.AppendLine("\t\t\talert('saved');");
            }
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t});");
            sb.AppendLine("\treturn false;");
            sb.AppendLine("});");

            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString EnableRefresh(this AjaxHelper ajaxHelper,
                                                  string elementName,
                                                  string controller,
                                                  string processMethod = null)
        {
            HtmlHelper htmlHelper = ajaxHelper.GetHtmlHelper();
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("$('#" + elementName + "').click(function (e) {");
            sb.AppendLine("\t$.ajax({");
            sb.AppendLine(
                "\t\turl: '" + new UrlHelper(HttpContext.Current.Request.RequestContext).Action(controller) + "',");
            sb.AppendLine("\t\ttype: 'GET',");
            sb.AppendLine("\t\tdataType: 'json',");
            sb.AppendLine("\t\tdata: null,");
            sb.AppendLine("\t\tsuccess: function (data) {");
            if (!String.IsNullOrEmpty(processMethod))
                sb.AppendLine("\t\t\t" + processMethod + "(data);");
            else
            {
                // default behavior is to copy to ViewModel
                sb.AppendLine("\t\t\tvar parsed=JSON.parse(data);");
                object model = ajaxHelper.ViewData.Model;
                Type type = model.GetType();
                string name = type.Name;
                PropertyInfo[] props = type.GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    if (prop.PropertyType.IsArray || prop.PropertyType.IsConstructedGenericType)
                        continue;

                    sb.AppendLine("\t\t\twindow.vm." + prop.Name + "(parsed." + prop.Name + ");");
                }
//                sb.AppendLine("\t\t\tko.applyBindings(" + name + ");");
            }
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t});");
            sb.AppendLine("\treturn false;");
            sb.AppendLine("});");

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}