using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AriansenBlog.Model
{
    public class AccordionMenu
    {
        public int? MenuItemId { get; set; }
        public String MenuName { get; set; }
        public String LinkAddress { get; set; }
        public int? SortIndex { get; set; }
        public int? ParentId { get; set; }
        public Boolean IsParent { get; set; }
        public Boolean IsVisible { get; set; }
        public String Target { get; set; }
    }
}