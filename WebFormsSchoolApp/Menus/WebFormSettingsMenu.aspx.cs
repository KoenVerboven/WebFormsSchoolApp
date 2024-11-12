using System;


namespace WebFormsSchoolApp.Menus
{
    public partial class WebFormSettingsMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            LinkButtonChangePassword.Visible = true;
            LinkButtonAdvancedSettings.Visible = true;
        }

        protected void LinkButtonChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Settings/WebFormChangePassword.aspx");
        }
    }
}