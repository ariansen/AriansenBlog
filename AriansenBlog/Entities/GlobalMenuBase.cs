using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AriansenBlog.AriansenBlog.Entities
{
    public class GlobalMenuBase
    {
        #region Properties
        public int MenuID { get; set; }
        public String MenuName { get; set; }
        public String Description { get; set; }
        public Boolean IsParent { get; set; }
        public String Url { get; set; }
        #endregion
    }
}