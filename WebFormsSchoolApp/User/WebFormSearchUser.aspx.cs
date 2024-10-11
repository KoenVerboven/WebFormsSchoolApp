using System;


namespace WebFormsSchoolApp.User
{
    public partial class WebFormSearchUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }
    }
}