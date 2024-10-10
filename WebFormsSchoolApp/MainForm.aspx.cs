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
            //LabelUser.ForeColor = Color.White;
            LabelUser.Text = "User : " + Session["user"].ToString();
        }

        protected void LinkButtonStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("students.aspx");
        }
    }
}