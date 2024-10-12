using System;
using System.Drawing;


namespace WebFormsSchoolApp
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void LinkButtonStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("students.aspx");
        }

    }
}