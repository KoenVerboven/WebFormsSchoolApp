﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;


namespace WebFormsSchoolApp.Student
{
    public partial class WebFormSearchStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var students = new List<models.Student>()
            {
                new models.Student{
                    PersonId = 1,
                    LastName = "Poels",
                    Firstname = "Maria",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 2,
                    LastName = "Verboven",
                    Firstname = "Johan",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 3,
                    LastName = "Verboven",
                    Firstname = "Koen",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 4,
                    LastName = "Peeters",
                    Firstname = "Jos",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 5,
                    LastName = "Gevers",
                    Firstname = "An",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 6,
                    LastName = "Pieters",
                    Firstname = "Mark",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 7,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    RegistrationDate = DateTime.Now,
                },

                new models.Student{
                    PersonId = 8,
                    LastName = "Vertonghen",
                    Firstname = "Mark",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 9,
                    LastName = "Van De Veire",
                    Firstname = "Els",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 10,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    RegistrationDate = DateTime.Now,
                },
                 new models.Student{
                    PersonId = 11,
                    LastName = "Dhondt",
                    Firstname = "Sean",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 12,
                    LastName = "Huisman",
                    Firstname = "Josje",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 13,
                    LastName = "Brusselmans",
                    Firstname = "Jan",
                    RegistrationDate = DateTime.Now,
                },
                new models.Student{
                    PersonId = 14,
                    LastName = "van Aert",
                    Firstname = "Wout",
                    RegistrationDate = DateTime.Now,
                },


            };

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                GridView1.DataSource = students;
                GridView1.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Response.Redirect("WebFormStudentDetail.aspx?studentId=" + row.Cells[2].Text.Trim());
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}