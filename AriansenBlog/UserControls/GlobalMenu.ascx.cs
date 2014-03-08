using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AriansenBlog.Templates.Units
{
    public partial class GlobalMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var globalMenuList = AriansenBlog.Entities.GlobalMenu.GetGlobalMenu();

            repGlobalMenu.DataSource = globalMenuList.Where(p => p.intParentID == 1).OrderBy(p => p.intIndex);
            repGlobalMenu.DataBind();
        }
    }
}