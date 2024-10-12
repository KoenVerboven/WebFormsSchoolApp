using System;
using System.Web.UI;


// todo : Replace Mainform.aspx  by default.aspx
// todo : insert page : validation + mark required fields
// todo  : defautl page : colored square panes with icon in place of hrefs
// todo : checkbox in gridvew in place of true and false
// tot : conection string

namespace WebFormsSchoolApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}