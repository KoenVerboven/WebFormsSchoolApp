using SchoolappBackend.BLL.BLLClasses;
using System;

namespace WebFormsSchoolApp.Student
{
    public partial class WebFormStudentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int personId = 0;
            string action = string.Empty;

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    personId = Convert.ToInt32(Request.QueryString["studentId"]);
                    action = Request.QueryString["action"];

                    if(action=="detail" || action == "update")
                    {
                        StudentBLL studentBLL = new StudentBLL();
                        var studentSelected = studentBLL.GetStudentById(personId);

                        LabelStudentIdValue.Text = studentSelected.PersonId.ToString();
                        TextBoxLastName.Text = studentSelected.LastName.ToString();
                        TextBoxFirstName.Text = studentSelected.Firstname.ToString();
                        TextBoxMiddleName.Text = studentSelected.MiddleName.ToString();
                        TextBoxStreetAndNumber.Text = studentSelected.StreetAndNumber.ToString();
                        TextBoxZipCode.Text = studentSelected.ZipCode.ToString();
                        TextBoxPhoneNumber.Text = studentSelected.PhoneNumber.ToString();
                        TextBoxEmailAddress.Text = studentSelected.EmailAddress.ToString();
                        TextBoxDateOfBirth.Text = studentSelected.DateOfBirth.ToString("dd-MM-yyyy");
                        TextBoxRegistrationDate.Text = studentSelected.RegistrationDate.ToString("dd-MM-yyyy");
                    }
                    
                    switch (action) 
                    {
                        case "detail":
                            LabelTitle.Text = "Student Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new Student";
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update Student";
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        default:
                            LabelTitle.Text = "Student Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ButtonSaveAndCancelVisible(bool visible)
        {
            ButtonSave.Visible = visible;
            ButtonCancel.Visible = visible;
        }

        private void DisableAllControls(bool disable)
        {
            var enableControl = !disable;
            TextBoxLastName.Enabled = enableControl;
            TextBoxFirstName.Enabled = enableControl;
            TextBoxMiddleName.Enabled = enableControl;
            TextBoxStreetAndNumber.Enabled = enableControl;
            TextBoxZipCode.Enabled = enableControl;
            TextBoxPhoneNumber.Enabled = enableControl;
            TextBoxEmailAddress.Enabled = enableControl;
            TextBoxDateOfBirth.Enabled = enableControl;
            TextBoxRegistrationDate.Enabled = enableControl;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //save
            }
            else
            {
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchStudent.aspx");
        }
    }
}