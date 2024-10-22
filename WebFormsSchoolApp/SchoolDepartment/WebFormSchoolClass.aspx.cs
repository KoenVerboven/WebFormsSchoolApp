using System;

namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../loginSchool.aspx");
            }
        }
    }
}