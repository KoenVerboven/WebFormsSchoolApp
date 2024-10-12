﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebFormsSchoolApp.Student
{
    public partial class WebFormStudentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int personId = 0;
            string action = string.Empty;

            var students = new List<models.Student>()
            {
                new models.Student{
                    PersonId = 1,
                    LastName = "Poels",
                    Firstname = "Maria",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1974,4,12),
                    RegistrationDate = new DateTime(2023,8,1),
                },
                new models.Student{
                    PersonId = 2,
                    LastName = "Verboven",
                    Firstname = "Johan",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1999,1,31),
                    RegistrationDate = new DateTime(2023,8,5),
                },
                new models.Student{
                    PersonId = 3,
                    LastName = "Verboven",
                    Firstname = "Koen",
                    MiddleName = "Frans Maria",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1966,6,1),
                    RegistrationDate = new DateTime(2023,8,9),
                },
                new models.Student{
                    PersonId = 4,
                    LastName = "Peeters",
                    Firstname = "Jos",
                    MiddleName = "",
                    StreetAndNumber ="Kerkstraat 13",
                    ZipCode = "5200",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2002,3,13),
                    RegistrationDate = new DateTime(2023,8,13),
                },
                new models.Student{
                    PersonId = 5,
                    LastName = "Gevers",
                    Firstname = "An",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 14",
                    ZipCode = "6000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2000,1,3),
                    RegistrationDate = new DateTime(2024,7,15),
                },
                new models.Student{
                    PersonId = 6,
                    LastName = "Pieters",
                    Firstname = "Mark",
                    MiddleName = "",
                    StreetAndNumber ="Fazantenlaan 4",
                    ZipCode = "9000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1995,9,1),
                    RegistrationDate = new DateTime(2024,7,16),
                },
                new models.Student{
                    PersonId = 7,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    MiddleName = "",
                    StreetAndNumber ="Koolhof 45a",
                    ZipCode = "4500",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1986,3,3),
                    RegistrationDate = new DateTime(2024,6,30),
                },

                new models.Student{
                    PersonId = 8,
                    LastName = "Vertonghen",
                    Firstname = "Mark",
                    MiddleName = "",
                    StreetAndNumber ="Koolhof 46a",
                    ZipCode = "3000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1987,4,2),
                    RegistrationDate = new DateTime(2024,6,29),
                },
                new models.Student{
                    PersonId = 9,
                    LastName = "Van De Veire",
                    Firstname = "Els",
                    MiddleName = "",
                    StreetAndNumber ="Berkenhei 1",
                    ZipCode = "4000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1977,6,12),
                    RegistrationDate = new DateTime(2024,6,22),
                },
                new models.Student{
                    PersonId = 10,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    MiddleName = "",
                    StreetAndNumber ="Grotebaan 48a",
                    ZipCode = "4000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1965,5,12),
                    RegistrationDate = new DateTime(2024,7,24),
                },
                 new models.Student{
                    PersonId = 11,
                    LastName = "Dhondt",
                    Firstname = "Sean",
                    MiddleName = "",
                    StreetAndNumber ="Antwerpsesteenweg 455",
                    ZipCode = "9000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2004,4,22),
                    RegistrationDate = new DateTime(2024,7,15),
                },
                new models.Student{
                    PersonId = 12,
                    LastName = "Huisman",
                    Firstname = "Josje",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 1",
                    ZipCode = "5444",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2001,3,4),
                    RegistrationDate = new DateTime(2024,7,16),
                },
                new models.Student{
                    PersonId = 13,
                    LastName = "Brusselmans",
                    Firstname = "Jan",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 45",
                    ZipCode = "2330",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2003,4,7),
                    RegistrationDate = new DateTime(2024,8,5),
                },
                new models.Student{
                    PersonId = 14,
                    LastName = "van Aert",
                    Firstname = "Wout",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 78",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1974,9,12),
                    RegistrationDate = new DateTime(2024,9,6)
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
                    personId = Convert.ToInt32(Request.QueryString["studentId"]);
                    action = Request.QueryString["action"];

                    if(action=="detail" || action == "update")
                    {
                        var studentSelected = students.SingleOrDefault(p => p.PersonId == personId);
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
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new Student";
                            DisableAllControls(false);
                            break;
                        case "update":
                            LabelTitle.Text = "Update Student";
                            DisableAllControls(false);
                            break;
                        default:
                            LabelTitle.Text = "Student Detail";
                            DisableAllControls(true);
                            break;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
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

    }
}