using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.AttendanceRegistration
{
    public partial class WebFormAttendanceRegistration : System.Web.UI.Page
    {
        List<StudentPresenceNotation> studentPresence;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
            if(!Page.IsPostBack)
            {
                LabelMessage.Visible = false;
                ShowClass();

                var schoolDepartmentBLL = new SchoolDepartmentBLL();
                var schoolClasses = schoolDepartmentBLL.GetClasses("", "", "");

                DropDownListClass.DataSource = schoolClasses;
                DropDownListClass.DataTextField = "ClassCodeAndDescription";
                DropDownListClass.DataValueField = "ClassId";
                DropDownListClass.DataBind();
            }
        }

        private void ShowClass()
        {
            var dtudentPresenceBLL = new StudentPresenceBLL();

            try
            {
                studentPresence = dtudentPresenceBLL.GetStudentPresence();
                GridView1.DataSource = studentPresence;
                GridView1.DataBind();
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible=true;
                LabelMessage.Text=oEx.Message;
            }
        }

        protected void ButtonSave_Click1(object sender, EventArgs e)
        {
            SaveDate();
        }

        private bool SaveDate()
        {
            bool succes = false;
            StudentPresenceBLL studentPresenceBLL = new StudentPresenceBLL();

            try
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        int studentId = Convert.ToInt32((row.FindControl("StudentId") as Label).Text);
                        bool presence = (row.FindControl("Presence") as CheckBox).Checked;
                        string remarks = (row.FindControl("TextBoxRemarks") as TextBox).Text;
                        var studentPresenceNotation = new StudentPresenceNotation()
                        {
                            StudentId = studentId,
                            ClassId =  Convert.ToInt32(DropDownListClass.SelectedValue),
                            Presence = presence,
                            Comment = remarks,
                            CourseLessonId = 1,//todo aanpassen
                            NotedByTeacherId = 1,//todo aanpassen
                            NotationDate = DateTime.Now,
                        };

                        succes = studentPresenceBLL.Add(studentPresenceNotation);//success aanpassen geeft niet het eindresultaat

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return succes;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../StartPage.aspx");
        }
    }
}