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
              //  LinkButton1.Text = "Check out user : " + Session["user"].ToString();
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
           // LinkButton1.Text = "User is uitgecheckt.";
            Response.Redirect("~/");


            //< li class="nav-item">
            //                <asp:LinkButton ID = "LinkButton1" runat="server" OnClick="LinkButton1_Click" width="250px" >Check Out</asp:LinkButton></li>--%>
        }
    }
}