using System;
using System.Web.UI;


namespace WebFormsSchoolApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("StartPage.aspx");
            }
            Labelfooter.Text = " Belgium - Vosselaar    " + DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}