using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;


namespace WebFormsSchoolApp.User
{
    public partial class WebFormSearchUser : System.Web.UI.Page
    {

        List<SchoolappBackend.BLL.models.User> users;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
            if(! Page.IsPostBack)
            {
                LabelMessage.Visible = false;
            }
            GridView1.EmptyDataText = "No Users found. Please adjust your search condition.";
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Button btn = sender as Button;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                int rowIndex = gRow.RowIndex;
                var userId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[1].Text);
                UserBLL userBLL = new UserBLL();
                userBLL.Delete(userId);
                Search("", "");
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible=true;
                LabelMessage.Text = oEx.Message;
            }
            Search("", "");
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int rowIndex = gRow.RowIndex;
            var userId = GridView1.Rows[rowIndex].Cells[1].Text;
            Response.Redirect("WebFormUserDetail.aspx?userId=" + userId + "&action=update");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Session["searchUser"] = TextBoxSearch.Text.Trim();
                    Response.Redirect("WebFormUSerDetail.aspx?userId=" + row.Cells[1].Text.Trim() + "&action=detail");
                }

            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Search("", "");
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

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search("","");
        }

        private void Search(string orderBy, string sortDirection)
        {
            try
            {
                var userBLL = new UserBLL();
                users = userBLL.GetUsers(TextBoxSearch.Text.Trim(), orderBy, sortDirection);

                GridView1.DataSource = users;
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
            Response.Redirect("WebFormUserDetail.aspx?userId=0&action=insert");
        }
    }
}