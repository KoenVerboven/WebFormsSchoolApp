using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

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
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 2,
                    LastName = "Vervoort",
                    Firstname = "Els",
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 3,
                    LastName = "Michiels",
                    Firstname = "Peter",
                    HireDate = DateTime.Now
                },
                new models.Teacher{
                    PersonId = 4,
                    LastName = "Neutenboom",
                    Firstname = "Pascal",
                    HireDate = DateTime.Now
                },

            };

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            if (Session["searchTeacher"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchTeacher"]);
                Search();
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
                    Response.Redirect("WebFormTeacherDetail.aspx?teacherId=" + row.Cells[1].Text.Trim());
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
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
            if (teachers != null)
            {
                teachers = teachers
                             .Where(X => X.FullName.ToLower().Contains(TextBoxSearch.Text.ToLower())
                                       ).ToList();
                GridView1.DataSource = teachers;
                GridView1.DataBind();
            }
        }


    }
}