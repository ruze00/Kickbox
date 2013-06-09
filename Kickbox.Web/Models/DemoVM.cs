using System.Collections.Generic;
using System.Web.Mvc;

namespace Kickbox.Web.Models
{
    public class DemoVM
    {
        public string Text { get; set; }
        public bool Check { get; set; }
        public string Hidden { get; set; }
        public string Password { get; set; }
        public string RadioButton { get; set; }
        public string RadioButtonFor { get; set; }
        public string DropDownSelected { get; set; }
        public IEnumerable<string> ListBoxSelected { get; set; }
        public IEnumerable<SelectListItem> DropDownListOptions { get; set; }
    }
}