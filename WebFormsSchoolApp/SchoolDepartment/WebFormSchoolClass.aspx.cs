using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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

            if (Session["searchSchoolClass"] != null)
            {
              
                TextBoxSearch.Text = Convert.ToString(Session["searchSchoolClass"]);
                Search("", "");
                Session["searchSchoolClass"] = null;
            }

            if (! Page.IsPostBack)
            {
                LabelMessage.Visible = false;
            }
        }

        private void Search(string orderBy, string sortDirection)
        {

            try
            {
                var schoolDepartmentBLL = new SchoolDepartmentBLL();
                schoolClasses = schoolDepartmentBLL.GetClasses(TextBoxSearch.Text.Trim(), orderBy, sortDirection);

                GridView1.DataSource = schoolClasses;
                GridView1.DataBind();
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible=false;
                LabelMessage.Text=oEx.Message;
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("","");
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSchoolClassDetail.aspx?SchoolClassId=0&action=insert");
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Button btn = sender as Button;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                int rowIndex = gRow.RowIndex;
                var schoolClassId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[1].Text);
                var schoolDepartmentBLL = new SchoolDepartmentBLL();
                //schoolDepartmentBLL.Delete();
                //Search("");
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = oEx.Message;
            }
            Search("", "");
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                int rowIndex = gRow.RowIndex;
                var SchoolClassId = GridView1.Rows[rowIndex].Cells[1].Text;
                Session["searchSchoolClass"] = TextBoxSearch.Text.Trim();
                Response.Redirect("WebFormSchoolClassDetail.aspx?SchoolClassId=" + SchoolClassId + "&action=update");
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible=true;
                LabelMessage.Text = oEx.Message;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Search("", ""  );
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Session["searchSchoolClass"] = TextBoxSearch.Text.Trim();
                    Response.Redirect("WebFormSchoolClassDetail.aspx?SchoolClassId=" + row.Cells[1].Text.Trim() + "&action=detail");
                }
            }
        }

        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
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
    }
}