﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebFormsSchoolApp.models;

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
                    MiddleName = "",
                    StreetAndNumber ="Grote Weg 441",
                    ZipCode = "3000",
                    PhoneNumber = "2782578528",
                    EmailAddress = "Danny@test.be",
                    DateOfBirth = new DateTime(1980,4,15),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.A1,
                    SeniorityYears = 1
                },
                new models.Teacher{
                    PersonId = 2,
                    LastName = "Vervoort",
                    Firstname = "Els",
                    MiddleName = "",
                    StreetAndNumber ="Beersebaan 33",
                    ZipCode = "4000",
                    PhoneNumber = "23783287468",
                    EmailAddress = "Els@test.be",
                    DateOfBirth = new DateTime(1999,4,12),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.C1,
                    SeniorityYears = 6
                },
                new models.Teacher{
                    PersonId = 3,
                    LastName = "Michiels",
                    Firstname = "Peter",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6258527468",
                    EmailAddress = "Peter@test.be",
                    DateOfBirth = new DateTime(1982,3,2),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.A2,
                    SeniorityYears = 4
                },
                new models.Teacher{
                    PersonId = 4,
                    LastName = "Neutenboom",
                    Firstname = "Pascal",
                    MiddleName = "",
                    StreetAndNumber ="Turnhoutsebaan 33",
                    ZipCode = "4000",
                    PhoneNumber = "6463653868",
                    EmailAddress = "Peter@test.be",
                    DateOfBirth = new DateTime(2005,3,2),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.C1,
                    SeniorityYears = 12
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
                    TextBoxMiddleName.Text = teacherSelected.MiddleName.ToString();
                    TextBoxStreetAndNumber.Text = teacherSelected.StreetAndNumber.ToString();
                    TextBoxZipCode.Text = teacherSelected.ZipCode.ToString();
                    TextBoxPhoneNumber.Text = teacherSelected.PhoneNumber.ToString();
                    TextBoxEmailAddress.Text = teacherSelected.EmailAddress.ToString();
                    TextBoxDateOfBirth.Text = teacherSelected.DateOfBirth.ToString("dd-MM-yyyy");
                    TextBoxHireDate.Text = Convert.ToString(teacherSelected.HireDate.ToString("dd-MM-yyyy"));
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