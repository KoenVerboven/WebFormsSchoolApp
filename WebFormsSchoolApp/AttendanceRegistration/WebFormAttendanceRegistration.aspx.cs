using System;

namespace WebFormsSchoolApp.AttendanceRegistration
{
    public partial class WebFormAttendanceRegistration : System.Web.UI.Page
    {
       // List<models.Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            ShowClass();
        }

        private void ShowClass()
        {
            //if (students != null)
            //{
            //    students = students
            //                .OrderBy(x => x.FullName)
            //                .ToList();

            //    GridView1.DataSource = students;
            //    GridView1.DataBind();

            //}
        }
    }
}