﻿using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;


namespace WebFormsSchoolApp.Teacher
{
    public partial class WebFormTeacherDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int teacherId = 0;
            string action = string.Empty;

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    teacherId = Convert.ToInt32(Request.QueryString["teacherId"]);
                    action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;

                    if (action == "detail" || action == "update")
                    {
                        TeacherBLL teacherBLL = new TeacherBLL();
                        var teacherSelected = teacherBLL.GetTeacherById(teacherId);

                        LabelTeacherIdValue.Text = Convert.ToString(teacherSelected.PersonId);
                        TextBoxLastName.Text = teacherSelected.LastName;
                        TextBoxFirstName.Text = teacherSelected.Firstname;
                        TextBoxMiddleName.Text = teacherSelected.MiddleName.ToString();
                        TextBoxStreetAndNumber.Text = teacherSelected.StreetAndNumber.ToString();
                        TextBoxZipCode.Text = teacherSelected.ZipCode.ToString();
                        TextBoxPhoneNumber.Text = teacherSelected.PhoneNumber.ToString();
                        TextBoxEmailAddress.Text = teacherSelected.EmailAddress.ToString();
                        TextBoxDateOfBirth.Text = teacherSelected.DateOfBirth.ToString("dd-MM-yyyy");
                        TextBoxHireDate.Text = Convert.ToString(teacherSelected.HireDate.ToString("dd-MM-yyyy"));
                        TextBoxLeaveDate.Text = Convert.ToString(teacherSelected.LeaveDate);

                    }

                    switch (action)
                    {
                        case "detail":
                            LabelTitle.Text = "Student Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new Teacher";
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update Teacher";
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
            TextBoxHireDate.Enabled = enableControl;
            TextBoxLeaveDate.Enabled = enableControl;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (SaveData())
                {
                    Response.Redirect("WebFormSearchTeacher.aspx");
                }
            }
        }

        private bool SaveData()
        {
            bool succes = false;
            TeacherBLL teacherBLL = new TeacherBLL();

            var teacher = new SchoolappBackend.BLL.models.Teacher()
            {
                PersonId = Convert.ToInt32(LabelTeacherIdValue.Text),
                LastName = TextBoxLastName.Text.Trim(),
                MiddleName = TextBoxMiddleName.Text.Trim(),
                Firstname = TextBoxFirstName.Text.Trim(),
                StreetAndNumber = TextBoxStreetAndNumber.Text.Trim(),
                ZipCode = TextBoxZipCode.Text.Trim(),
                PhoneNumber = TextBoxPhoneNumber.Text.Trim(),
                EmailAddress = TextBoxEmailAddress.Text.Trim(),
                DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text.Trim()),
                HireDate = Convert.ToDateTime(TextBoxHireDate.Text.Trim()),
                LeaveDate = DateTime.Now,//Convert.ToDateTime(TextBoxLeaveDate.Text.Trim()), //todo
                SaleryCategorie = SchoolappBackend.BLL.models.SaleryCategorie.A1,//todo SaleryCategorie
                SeniorityYears = 1 //todo SeniorityYears
            };

            if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
            {
                succes = teacherBLL.Update(teacher);
            }

            if (HiddenFieldAction.Value == "insert") //todo rplc string action in to enum
            {
                succes = teacherBLL.Add(teacher);
            }
            return succes;
        }


        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchTeacher.aspx");
        }
    }
}