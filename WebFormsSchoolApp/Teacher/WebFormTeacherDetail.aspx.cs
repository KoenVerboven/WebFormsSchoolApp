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

                    if(action == "detail" || action == "update")
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
                //save
            }
            else
            {
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchTeacher.aspx");
        }
    }
}