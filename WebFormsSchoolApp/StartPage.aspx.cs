using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessage.Visible = false;
            if (!IsPostBack)
            {
                if (Request.Cookies["SchoolLogin"] != null)
                {
                    TextBoxId.Text = Request.Cookies["SchoolLogin"].Value;
                }
            }

        }

        private SchoolappBackend.BLL.models.User ValidUser()
        {

            UserBLL user = new UserBLL();
            SchoolappBackend.BLL.models.User userFound = null;

            try
            {
                userFound = user.GetUserByUserNameAndPassword(TextBoxId.Text.Trim(), TextBoxPassword.Text.Trim());
            }
            catch (Exception)
            {
                throw;
            }
            
            if (userFound != null)
            {
                return userFound;
            }
            else
            {
                return null;
            }
        }

        //todo privacy
        //https://www.websiteacademy.nl/gdpr-avg/#Extra_vinkjes
        //https://cloudwise.nl/bewaren-van-persoonsgegevens/
        //https://www.iubenda.com/nl/help/106784-gdpr-consent-form-examples-what-to-do-and-not-to-do
        //https://www.gegevensbeschermingsautoriteit.be/professioneel/avg/rechtsgronden/toestemming
        private void SetCookie(string inlogId) //todo : legaal vragen of user cookies goedkeurd
        {
            HttpCookie cookie = new HttpCookie("SchoolLogin");
            cookie.Value = inlogId;
            cookie.Expires = DateTime.Now.AddHours(3);
            Response.SetCookie(cookie);
        }

        protected void ButtonLogin_Click1(object sender, EventArgs e)
        {
            try
            {
                SchoolappBackend.BLL.models.User validUser = ValidUser();

                if (validUser != null)
                {
                    
                    Session["user"] = TextBoxId.Text.Trim();
                    Session["userRole"] = ValidUser().UserRoleId; 
                    SetCookie(TextBoxId.Text.Trim());
                    Response.Redirect("default.aspx");
                }
                else
                {
                    LabelMessage.Visible = true;
                    LabelMessage.Text = "Authentication failed";
                }
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = oEx.Message;
            }
        }
    }
}