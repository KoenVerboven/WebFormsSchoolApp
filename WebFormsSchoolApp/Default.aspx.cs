using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Web.UI;



// todo : Replace Mainform.aspx  by default.aspx
// todo : insert page : validation + mark required fields
// todo : checkbox in gridvew in place of true and false

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
            StudentBLL studentBLL = new StudentBLL();
            LabelStudent.Text = "Student (" + studentBLL.StudentCount() +")";
            TeacherBLL teacherBLL = new TeacherBLL();
            LabelTeacher.Text= "Teacher (" + teacherBLL.TeacherCount() + ")";
            UserBLL userBLL = new UserBLL();
            LabelUser.Text = "User (" + userBLL.UserCount() + ")";
            CourseBLL courseBLL = new CourseBLL();
            LabelCourse.Text = "Course (" + courseBLL.CourseCount() + ")";
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