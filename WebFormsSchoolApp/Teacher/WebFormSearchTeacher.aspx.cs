using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.Teacher
{
    public partial class WebFormSearchTeacher : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.Teacher> teachers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            if (Session["searchTeacher"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchTeacher"]);
                Search("","");
                Session["searchTeacher"] = null;
            }

            if(!Page.IsPostBack)
            {
                LabelMessage.Visible = false;
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
            Search("", "");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("", "");
        }

        private void Search(string orderBy, string sortDirection)
        {
            try
            {
                TeacherBLL teachertBLL = new TeacherBLL();
                teachers = teachertBLL.GetTeachers(TextBoxSearch.Text.Trim(), orderBy, sortDirection);

                GridView1.DataSource = teachers;
                GridView1.DataBind();
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = oEx.Message;
            }
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormTeacherDetail.aspx?teacherId=0&action=insert");
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (HiddenFieldSortDirection.Value == "ASC")
            {
                HiddenFieldSortDirection.Value = "DESC";
            }
            else
            {
                HiddenFieldSortDirection.Value = "ASC";
            }
            Search(e.SortExpression.ToString(), HiddenFieldSortDirection.Value);
        }

        
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var teacherId = GridView1.Rows[rowIndex].Cells[1].Text;
            Session["searchTeacher"] = TextBoxSearch.Text.Trim();
            Response.Redirect("WebFormTeacherDetail.aspx?TeacherId=" + teacherId + "&action=update");
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var teacherId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[1].Text);
            TeacherBLL teacherBLL = new TeacherBLL();
            teacherBLL.Delete(teacherId);
            Search("", "");
        }
    }
}