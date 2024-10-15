using SchoolappBackend;
using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;


namespace WebFormsSchoolApp.Student
{
    public partial class WebFormSearchStudent : System.Web.UI.Page
    {

        List<SchoolappBackend.BLL.models.Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            if(Session["searchStudent"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchStudent"]);
                Search("");
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
            Search("");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("");
        }

        private void Search(string orderBy)
        {
            StudentBLL studentBLL = new StudentBLL();
            students = studentBLL.GetStudents(TextBoxSearch.Text.Trim(), orderBy);

            GridView1.DataSource = students;
            GridView1.DataBind();
        }


        protected void ButtonNew_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebFormStudentDetail.aspx?studentId=0&action=insert");
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            Search(e.SortExpression.ToString());
        }

        
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

            }
            catch (Exception oEx)
            {
                LabelErrorMessage.Text = oEx.Message;
            }
            var studentId = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[1].Text);
            var studentToRemove = students.SingleOrDefault(p=>p.PersonId == studentId);
            students.Remove(studentToRemove);
            Search("");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var studentId = GridView1.Rows[e.NewEditIndex].Cells[1].Text;
            Response.Redirect("WebFormStudentDetail.aspx?studentId=" + studentId + "&action=update");
        }
    }
}