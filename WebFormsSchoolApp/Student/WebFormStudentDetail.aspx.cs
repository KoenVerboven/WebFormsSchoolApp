﻿using SchoolappBackend.BLL.BLLClasses;
using System;


namespace WebFormsSchoolApp.Student
{
    public partial class WebFormStudentDetail : System.Web.UI.Page
    {
        int personId = 0; // todo underscore _personid
        const string subject = "Student";

        protected void Page_Load(object sender, EventArgs e)
        {
           
            string action = string.Empty;
           
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            try
            {

                if (!IsPostBack)
                {
                    LabelMessage.Visible = false;
                    personId = Convert.ToInt32(Request.QueryString["studentId"]);
                    action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;
                    TextBoxRegistrationDate.Text =  DateTime.Now.ToString("dd/MM:yyyy");

                    DropDownListGender.DataSource = Enum.GetValues(typeof(Gender));
                    DropDownListGender.DataBind();
                    DropDownListMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
                    DropDownListMaritalStatus.DataBind();
                    DropDownListNationality.DataSource = Enum.GetValues(typeof(Nationality));
                    DropDownListNationality.DataBind();

                    if (action=="detail" || action == "update")
                    {
                        StudentBLL studentBLL = new StudentBLL();
                        var studentSelected = studentBLL.GetStudentById(personId);

                        LabelStudentIdValue.Text = studentSelected.PersonId.ToString();
                        TextBoxLastName.Text = studentSelected.LastName.ToString();
                        TextBoxFirstName.Text = studentSelected.Firstname.ToString();
                        TextBoxMiddleName.Text = studentSelected.MiddleName.ToString();
                        TextBoxStreetAndNumber.Text = studentSelected.StreetAndNumber.ToString();
                        TextBoxNationalRegisterNr.Text = studentSelected.NationalRegisterNumber;
                        TextBoxZipCode.Text = studentSelected.ZipCode.ToString();
                        TextBoxPhoneNumber.Text = studentSelected.PhoneNumber.ToString();
                        TextBoxEmailAddress.Text = studentSelected.EmailAddress.ToString();
                        TextBoxDateOfBirth.Text = studentSelected.DateOfBirth.ToString("dd-MM-yyyy");
                        TextBoxRegistrationDate.Text = studentSelected.RegistrationDate.ToString("dd-MM-yyyy");
                        DropDownListGender.SelectedIndex = studentSelected.Gender;
                        DropDownListNationality.SelectedIndex = studentSelected.Nationality;
                        DropDownListMaritalStatus.SelectedIndex = studentSelected.MaritalStatus;
                    }
                    
                    switch (action) 
                    {
                        case "detail":
                            LabelTitle.Text = subject +" Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        default:
                            LabelTitle.Text = subject + " Detail";
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
            TextBoxNationalRegisterNr.Enabled = enableControl;  
            TextBoxRegistrationDate.Enabled = enableControl;
            TextBox1ParentContactTelNr.Enabled = enableControl;
            TextBox2ParentContactTelNr.Enabled = enableControl;
            DropDownListGender.Enabled = enableControl;
            DropDownListMaritalStatus.Enabled = enableControl;  
            DropDownListNationality.Enabled = enableControl;    
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            var ServerSideValidationIsValid = true;

            if(! App_Code.ValidationUtilities.IsValidEmail(TextBoxEmailAddress.Text.Trim()))
            {
                LabelMessage.Text = "e-mail is not valid";
                LabelMessage.Visible = true;
                ServerSideValidationIsValid = false;
            }
            
            if (!App_Code.ValidationUtilities.IsValidBelgiumPhoneNr(TextBoxPhoneNumber.Text.Trim()))
            {
                LabelMessage.Text = "PhoneNumber is not valid";
                LabelMessage.Visible = true;
                ServerSideValidationIsValid = false;
            }

            if (!App_Code.ValidationUtilities.IsValidBelgiumZipCode(TextBoxZipCode.Text.Trim()))
            {
                LabelMessage.Text = "ZipCode is not valid";
                LabelMessage.Visible = true;
                ServerSideValidationIsValid = false;
            }

            if (Page.IsValid && ServerSideValidationIsValid)
            {
                if(SaveData())
                {
                    Response.Redirect("WebFormSearchStudent.aspx");
                }
            }
        }

        
        private bool SaveData()
        {
            bool succes = false;
            StudentBLL studentBLL = new StudentBLL();
            var personId = 0;

            try
            {
                if (HiddenFieldAction.Value == "update")
                {
                    personId = Convert.ToInt32(LabelStudentIdValue.Text.Trim());
                }

                var student = new SchoolappBackend.BLL.models.Student()
                {
                    PersonId = personId,
                    LastName = TextBoxLastName.Text.Trim(),
                    MiddleName = TextBoxMiddleName.Text.Trim(),
                    Firstname = TextBoxFirstName.Text.Trim(),
                    StreetAndNumber = TextBoxStreetAndNumber.Text.Trim(),
                    ZipCode = TextBoxZipCode.Text.Trim(),
                    PhoneNumber = TextBoxPhoneNumber.Text.Trim(),
                    Gender = DropDownListGender.SelectedIndex,
                    Nationality = DropDownListNationality.SelectedIndex,
                    NationalRegisterNumber = TextBoxNationalRegisterNr.Text.Trim(),
                    MaritalStatus = DropDownListMaritalStatus.SelectedIndex,
                    EmailAddress = TextBoxEmailAddress.Text.Trim(),
                    DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text.Trim()),
                    RegistrationDate = Convert.ToDateTime(TextBoxRegistrationDate.Text.Trim())
                };

                if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
                {
                    succes = studentBLL.Update(student);
                }

                if (HiddenFieldAction.Value == "insert") //todo rplc string action in to enum
                {
                    succes = studentBLL.Add(student);
                }
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = oEx.Message;
            }
            return succes;
        }



        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchStudent.aspx");
        }
    }
}