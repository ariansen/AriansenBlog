using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AriansenBlog.Model
{
    public class Menu
    {
        public int? MenuItemId { get; set; }
        public String MenuName { get; set; }
        public String Tooltip { get; set; }
        public Boolean IsParent { get; set; }
        public int? ParentId { get; set; }
        public Boolean IsVisible { get; set; }
        public int? SortIndex { get; set; }
    }
}