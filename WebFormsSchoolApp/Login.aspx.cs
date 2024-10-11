﻿using System;
using System.Web;

namespace WebFormsSchoolApp
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = System.Drawing.Color.Red;
            
            if(!IsPostBack)
            {
                if (Request.Cookies["SchoolLogin"] != null)
                {
                    TextBoxId.Text = Request.Cookies["SchoolLogin"].Value;
                }
            }
            
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            //if (TextBoxId.Text == "admin" && TextBoxPassword.Text == "admin")
            if (TextBoxId.Text == "admin" || TextBoxId.Text == "koen" || TextBoxId.Text == "johan")
            {
                Session["user"] = TextBoxId.Text.Trim();
                SetCookie(TextBoxId.Text.Trim());
                Response.Redirect("default.aspx");
            }
            else
            {
                LabelMessage.Text = "UserId or password is not valid";
            }
        }

        private void SetCookie(string inlogId) //doto : legaal vragen of user cookies goedkeurd
        {
            HttpCookie cookie = new HttpCookie("SchoolLogin");
            cookie.Value = inlogId; 
            cookie.Expires = DateTime.Now.AddHours(3);
            Response.SetCookie(cookie);
        }
    }
}