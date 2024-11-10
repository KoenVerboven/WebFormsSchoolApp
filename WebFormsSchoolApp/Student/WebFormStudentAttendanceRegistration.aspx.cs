using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Drawing;
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

                var schoolDepartmentBLL = new SchoolDepartmentBLL();
                var schoolClasses = new List<SchoolClass>();
                schoolClasses.Add(new SchoolClass { ClassId = -1, ClassCode = "Choose your class", Description = "" });
                schoolClasses.AddRange(schoolDepartmentBLL.GetClasses("", "Code", ""));

                DropDownListClass.DataSource = schoolClasses;
                DropDownListClass.DataTextField = "ClassCodeAndDescription";
                DropDownListClass.DataValueField = "ClassId";

                DropDownListClass.DataBind();
                DropDownListClass.AutoPostBack = true;
                int selValue = Convert.ToInt32(DropDownListClass.SelectedValue);
                ShowClass(selValue);
                GridView1.EmptyDataText = "No students found for this class.";
            }
        }

        private void ShowClass(int classId)
        {
            var dtudentPresenceBLL = new StudentPresenceBLL();

            try
            {
                studentPresence = dtudentPresenceBLL.GetStudentPresence(classId);
                GridView1.DataSource = studentPresence;
                GridView1.DataBind();
            }
            catch (Exception oEx)
            {
                ShowMessage(oEx.Message, ShowMessageType.error);
            }
        }

        protected void ButtonSave_Click1(object sender, EventArgs e)
        {
            if(SaveDate())
            {
                ShowMessage("The data has been saved successfully.", ShowMessageType.normal);
                DropDownListClass.SelectedIndex = 0;
                ShowClass(0);
            }
        }

        private bool SaveDate()
        {
            bool succes = true;
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
                            Comment = remarks,//todo foutmelding tonen of input lengte beperken commentaar mag max 60? lang zijn
                            CourseLessonId = 1,//todo aanpassen
                            NotedByTeacherId = 1,//todo aanpassen
                            NotationDate = DateTime.Now,
                        };

                        if(!studentPresenceBLL.Add(studentPresenceNotation))
                        {
                            succes = false;
                        }

                    }
                }
            }
            catch (Exception)
            {
                succes = false;
                throw;
            }
            return succes;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../StartPage.aspx");
        }

        protected void DropDownListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selValue = Convert.ToInt32(DropDownListClass.SelectedValue);
            ShowClass(selValue);
        }

        private void ShowMessage(string message, ShowMessageType showMessageType)
        {
            LabelMessage.Text = message;
            LabelMessage.Visible = true;

            if (showMessageType == ShowMessageType.normal)
            {
                LabelMessage.ForeColor = Color.Black; //todo : change css class insteat of this line
                LabelMessage.BackColor = Color.FromArgb(155, 233, 145);
            }

            if (showMessageType == ShowMessageType.error)
            {
                LabelMessage.ForeColor = Color.Black;
                LabelMessage.BackColor = Color.FromArgb(255, 140, 137);
            }
        }


    }
}