using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;

namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClass : System.Web.UI.Page
    {

        List<SchoolappBackend.BLL.models.SchoolClass> schoolClasses;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
        }

        private void Search(string orderBy)
        {
       
            SchoolDepartmentBLL schoolDepartmentBLL = new SchoolDepartmentBLL();
            schoolClasses = schoolDepartmentBLL.GetClasses(TextBoxSearch.Text.Trim(), orderBy);

            GridView1.DataSource = schoolClasses;
            GridView1.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("");
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {

        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {

        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Search("");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            Search(e.SortExpression.ToString());
        }
    }
}