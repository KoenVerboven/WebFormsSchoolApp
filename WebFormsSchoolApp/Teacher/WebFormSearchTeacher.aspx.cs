using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsSchoolApp.models;

namespace WebFormsSchoolApp.Teacher
{
    public partial class WebFormSearchTeacher : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.Teacher> teachers;

        protected void Page_Load(object sender, EventArgs e)
        {
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

            TeacherBLL teachertBLL = new TeacherBLL();
            teachers = teachertBLL.GetTeachers(TextBoxSearch.Text.Trim(), orderBy);

            GridView1.DataSource = teachers;
            GridView1.DataBind();
            
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