using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsSchoolApp.models;

namespace WebFormsSchoolApp.Teacher
{
    public partial class WebFormSearchTeacher : System.Web.UI.Page
    {

        List<models.Teacher> teachers;

        protected void Page_Load(object sender, EventArgs e)
        {
            teachers = new List<models.Teacher>()
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

            if (Session["searchTeacher"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchTeacher"]);
                Search("");
                Session["searchTeacher"] = null;
            }

            GridView1.EmptyDataText = "No teachers found. Please adjust your search condition.";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Session["searchTeacher"] = TextBoxSearch.Text.Trim();
                    Response.Redirect("WebFormTeacherDetail.aspx?teacherId=" + row.Cells[1].Text.Trim() + "&action=detail");
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Search("");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("");
        }

        private void Search(string orderBy)
        {
            if (teachers != null)
            {
                teachers = teachers
                             .Where(X => X.FullName.ToLower().Contains(TextBoxSearch.Text.ToLower())
                                       ).ToList();

                switch (orderBy)
                {
                    case "PersonId":
                        teachers = teachers.OrderBy(x => x.PersonId).ToList();
                        break;
                    case "FullName":
                        teachers = teachers.OrderBy(x => x.FullName).ToList();
                        break;
                    case "DateOfBirth":
                        teachers = teachers.OrderBy(x => x.DateOfBirth).ToList();
                        break;
                    default:
                        teachers = teachers.OrderBy(x => x.PersonId).ToList();
                        break;
                }

                GridView1.DataSource = teachers;
                GridView1.DataBind();
            }
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormTeacherDetail.aspx?teacherId=0&action=insert");
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            Search(e.SortExpression.ToString());
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var TeacherId = GridView1.Rows[e.NewEditIndex].Cells[1].Text;
            Response.Redirect("WebFormTeacherDetail.aspx?TeacherId=" + TeacherId + "&action=update");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var teacherId = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[1].Text);
            var teacherToRemove = teachers.SingleOrDefault(p => p.PersonId == teacherId);
            teachers.Remove(teacherToRemove);
            Search("");
        }
    }
}