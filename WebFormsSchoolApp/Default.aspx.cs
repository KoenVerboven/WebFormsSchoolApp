﻿using System;
using System.Web.UI;


// todo : Replace Mainform.aspx  by default.aspx

namespace WebFormsSchoolApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}