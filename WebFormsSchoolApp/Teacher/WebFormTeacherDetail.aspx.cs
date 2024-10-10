using System;
using System.Collections.Generic;
using System.Linq;

namespace WebFormsSchoolApp.Teacher
{
    public partial class WebFormTeacherDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int teacherId = 0;

            var teachers = new List<models.Teacher>()
            {
                new models.Teacher{
                    PersonId = 1,
                    LastName = "Verstraaten",
                    Firstname = "Danny",
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 2,
                    LastName = "Vervoort",
                    Firstname = "Els",
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 3,
                    LastName = "Michiels",
                    Firstname = "Peter",
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 4,
                    LastName = "Neutenboom",
                    Firstname = "Pascal",
                    HireDate = DateTime.Now
                },

            };

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    teacherId = Convert.ToInt32(Request.QueryString["teacherId"]);

                    var teacherSelected = teachers.SingleOrDefault(p => p.PersonId == teacherId);
                    LabelTeacherIdValue.Text = Convert.ToString(teacherSelected.PersonId);
                    TextBoxLastName.Text = teacherSelected.LastName;
                    TextBoxFirstName.Text = teacherSelected.Firstname;
                    TextBoxHireDate.Text = Convert.ToString(teacherSelected.HireDate);
                    TextBoxLeaveDate.Text = Convert.ToString(teacherSelected.LeaveDate);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}