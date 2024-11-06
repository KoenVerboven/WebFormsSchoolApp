using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.AttendanceRegistration
{
    public partial class WebFormAttendanceRegistration : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.StudentPresenceNotation> studentPresence;

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
            }
        }

        private void ShowClass()
        {
            StudentBLL studentBLL = new StudentBLL();

            try
            {
                studentPresence = studentBLL.GetStudentPresence();
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
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    int studentId = Convert.ToInt32((row.FindControl("StudentId") as Label).Text);
                    bool presence = (row.FindControl("Presence") as CheckBox).Checked;
                    string remarks = (row.FindControl("TextBoxRemarks") as TextBox).Text;

                    var studentPresenceNotation = new StudentPresenceNotation()
                    {
                        //StudentPresenceNotationId = 1,//todo moet waarschijnlijk niet pk is een autonummer
                        StudentId = studentId,
                        ClassId = 1,//to nog aanpassen naar het juiste class id
                        Presence = presence,
                        AbsenceReason = remarks,
                        NotationDate = DateTime.Now,
                    };

                    //Insert PresenceNotation in database

                }
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}