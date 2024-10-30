using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;

namespace WebFormsSchoolApp.AttendanceRegistration
{
    public partial class WebFormAttendanceRegistration : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
            if(!Page.IsPostBack)
            {
                LabelMessage.Visible = false;
            }
            ShowClass();
        }

        private void ShowClass()
        {
            StudentBLL studentBLL = new StudentBLL();
            students = studentBLL.GetStudents("", "LastName","ASC");

            GridView1.DataSource = students;
            GridView1.DataBind();
        }
    }
}