using System;
using System.Web.UI;




namespace WebFormsSchoolApp
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
               LinkButtonCheckOut.Text = "Check Out " + Session["user"].ToString();
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LinkButtonCheckOut.Text = "User is uitgecheckt.";
            Response.Redirect("~/");
        }
    }
}