using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;



namespace WebFormsSchoolApp.Student
{
    public partial class WebFormSearchStudent : System.Web.UI.Page
    {
        List<models.Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            students = new List<models.Student>()
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

            if(Session["searchStudent"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchStudent"]);
                Search();
                Session["searchStudent"] = null;
            }

            GridView1.EmptyDataText = "No students found. Please adjust your search condition.";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Session["searchStudent"] = TextBoxSearch.Text.Trim();
                    Response.Redirect("WebFormStudentDetail.aspx?studentId=" + row.Cells[1].Text.Trim()+"&action=detail");
                }

            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (students != null)
            {
                students = students
                             .Where(X => X.FullName.ToLower().Contains(TextBoxSearch.Text.ToLower())
                                       ).ToList();
                GridView1.DataSource = students;
                GridView1.DataBind();
    
            }
        }

 
        protected void ButtonNew_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebFormStudentDetail.aspx?studentId=0&action=insert");
        }
    }
}