﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AriansenBlog.AriansenBlog.Pages
{
    public partial class WriteArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.Form);

        }

        protected void SubmitPage(object sender, EventArgs e)
        {
            Response.Write(Request.Form);
        }
    }
}