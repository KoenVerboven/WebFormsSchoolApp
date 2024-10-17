using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.Course
{
    public partial class WebFormSearchCourse : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.Course> courses;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            if (Session["searchCourse"] != null)
            {
                TextBoxSearch.Text = Convert.ToString(Session["searchCourse"]);
                Search("");
                Session["searchCourse"] = null;
            }

            if(!IsPostBack)
            {
                DropDownListFilterActive.Items.Add("Show active");
                DropDownListFilterActive.Items.Add("Show all");
                DropDownListFilterActive.Items.Add("Show non active");
            }

            GridView1.EmptyDataText = "No courses found. Please adjust your search condition.";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Session["searchCourse"] = TextBoxSearch.Text.Trim();
                    Response.Redirect("WebFormCourseDetail.aspx?CourseId=" + row.Cells[1].Text.Trim() + "&action=detail");
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

            ActiveType activeType = ActiveType.All;

            if (DropDownListFilterActive.Items.Count > 0)
            {
                if (DropDownListFilterActive.SelectedItem.Text == "Show active") 
                {
                    activeType = ActiveType.Active;
                }
                if (DropDownListFilterActive.SelectedItem.Text == "Show non active") 
                {
                    activeType = ActiveType.NonActive;
                }
                if (DropDownListFilterActive.SelectedItem.Text == "Show all") 
                {
                    activeType = ActiveType.All;
                }
            }


            CourseBLL courseBLL = new CourseBLL();
            courses = courseBLL.GetCourses(TextBoxSearch.Text.Trim(), orderBy, activeType);
           
            GridView1.DataSource = courses;
            GridView1.DataBind();
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormCourseDetail.aspx?courseId=0&action=insert");
        }

        protected void GridView1_Sorting1(object sender, GridViewSortEventArgs e)
        {
            Search(e.SortExpression.ToString());
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var courseId = GridView1.Rows[rowIndex].Cells[1].Text;
            Response.Redirect("WebFormCourseDetail.aspx?courseId=" + courseId + "&action=update");
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var courseId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[1].Text);
            CourseBLL courseBLL = new CourseBLL();
            courseBLL.DeleteCourse(courseId);
            Search("");
        }
    }
}