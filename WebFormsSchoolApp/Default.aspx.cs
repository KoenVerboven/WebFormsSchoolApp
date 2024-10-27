using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Web.UI;

namespace WebFormsSchoolApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("StartPage.aspx");
            }

            //https://learn.microsoft.com/nl-nl/dotnet/csharp/fundamentals/coding-style/identifier-names
            //https://sandervandevelde.wordpress.com/2020/08/13/belgische-rijksregisternummer-checksum-testen-dutch/
            //https://www.c-sharp.be/asp-net/validatie/
            //rijksregister 11 lang
            //02021518897
            //int rijks = 02021518897;

            SetUserRights();

            StudentBLL studentBLL = new StudentBLL();
            LabelStudent.Text = "Student (" + studentBLL.StudentCount() +")";
            TeacherBLL teacherBLL = new TeacherBLL();
            LabelTeacher.Text= "Teacher (" + teacherBLL.TeacherCount() + ")";
            UserBLL userBLL = new UserBLL();
            LabelUser.Text = "User (" + userBLL.UserCount() + ")";
            CourseBLL courseBLL = new CourseBLL();
            LabelCourse.Text = "Course (" + courseBLL.CourseCount() + ")";
        }

        private void SetUserRights()
        {

            LinkButtonExamenPoints.Visible = false;
            LinkButtonStudent.Visible = false;
            LinkButtonCourse.Visible = false;
            LinkButtonAttendanceRegistration.Visible = false;
            LinkButtonClassOrganisation.Visible = false;
            LinkButtonTeacher.Visible = false;
            LinkButtonUser.Visible = false;
            LinkButtonUserRole.Visible = false;
            LinkButtonSchoolClass.Visible = false;

            if (Convert.ToString(Session["userRole"]) == "1" 
                              || Session["userRole"] is null)
            {
                LinkButtonExamenPoints.Visible = true;
            }
            if (Convert.ToString(Session["userRole"]) == "5")
            {
                LinkButtonStudent.Visible = true;
                LinkButtonCourse.Visible = true;
                LinkButtonAttendanceRegistration.Visible = true;
                LinkButtonClassOrganisation.Visible = true;
                LinkButtonExamenPoints.Visible = true;
                LinkButtonTeacher.Visible = true;
                LinkButtonUser.Visible = true;
                LinkButtonUserRole.Visible = true;
                LinkButtonSchoolClass.Visible = true;
            }
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student\\WebFormSearchStudent.aspx");
        }

        protected void LinkButtonSearchTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher\\WebFormSearchTeacher.aspx");
        }

        protected void LinkButtonSearchCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Course\\WebFormSearchCourse.aspx");
        }

        protected void LinkButtonSearchUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("User\\WebFormSearchUser.aspx");
        }

        protected void LinkButtonAttendanceRegistration_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AttendanceRegistration\\WebFormAttendanceRegistration.aspx");
        }

        protected void LinkButtonUserRole_Click(object sender, EventArgs e)
        {
            Response.Redirect("User\\WebFormUserRole.aspx");
        }

        protected void LinkButtonExamenPoints_Click(object sender, EventArgs e)
        {
            Response.Redirect("Exam\\WebFormExamPoints.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("SchoolDepartment\\WebFormSchoolClass.aspx");
        }

        protected void LinkButtonClassOrganisation_Click(object sender, EventArgs e)
        {
            Response.Redirect("SchoolDepartment\\WebFormSchoolClassOrganistation.aspx");
        }
    }
}