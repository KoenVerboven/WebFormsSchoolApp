using System;


namespace WebFormsSchoolApp.AttendanceRegistration
{
    public partial class WebFormAttendanceRegistration : System.Web.UI.Page
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