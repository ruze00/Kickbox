using System.Web.Mvc;
using Kickbox.Web.Models;

namespace Kickbox.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Helpers/

        public ActionResult Index()
        {
            var vm = DemoVM1();
            return View(vm);
        }

        [HttpPost]
        public JsonResult SaveData(DemoVM vm)
        {
            return Json(new { success = true });
        }

        public JsonResult GetData()
        {
            var vm = DemoVM2();
            var json = vm.ToJson();
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        private static DemoVM DemoVM1()
        {
            return new DemoVM
            {
                Text = "Text",
                Check = true,
                Hidden = "Hidden",
                Password = "kickboxPassword",
                RadioButton = "Chris",
                RadioButtonFor = "Ruze",
                DropDownListOptions = new[]
                {
                    new SelectListItem {Text = "Chris", Value = "ValueChris", Selected = true},
                    new SelectListItem {Text = "Ruze", Value = "ValueRuze"},
                    new SelectListItem {Text = "Ali", Value = "ValueAli"}
                }
            };
        }

        private static DemoVM DemoVM2()
        {
            return new DemoVM
            {
                Text = "TextNew",
                Check = true,
                Hidden = "HiddenNew",
                Password = "Password",
                RadioButton = "Ali",
                RadioButtonFor = "Chris",
                DropDownListOptions = new[]
                {
                    new SelectListItem {Text = "Chris", Value = "ValueChris"},
                    new SelectListItem {Text = "Ruze", Value = "ValueRuze", Selected = true},
                    new SelectListItem {Text = "Ali", Value = "ValueAli"}
                }
            };
        }
    }
}