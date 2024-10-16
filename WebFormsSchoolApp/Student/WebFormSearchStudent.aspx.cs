using SchoolappBackend;
using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Data;
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

        

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                Button btn = sender as Button;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                int rowIndex = gRow.RowIndex;
                var studentId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[1].Text);
                StudentBLL studentBLL = new StudentBLL();
                var test = studentBLL.DeleteStudent(studentId);
                GridView1.DataSource = test;
                GridView1.DataBind();
  
           
               

            }
            catch (Exception oEx)
            {
                LabelErrorMessage.Text = oEx.Message;
            }
            Search("");
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var studentId = GridView1.Rows[rowIndex].Cells[1].Text;
            Response.Redirect("WebFormStudentDetail.aspx?studentId=" + studentId + "&action=update");
        }
    }
}