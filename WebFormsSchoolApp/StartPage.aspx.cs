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

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (ValidUser() != null)
            {
                Session["user"] = TextBoxId.Text.Trim();
                SetCookie(TextBoxId.Text.Trim());
                Response.Redirect("default.aspx");
            }
            else
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = "Authentication failed";
            }
        }

        private SchoolappBackend.BLL.models.User ValidUser()
        {

            UserBLL user = new UserBLL();
            var userFound = user.GetUserByUserNameAndPassword(TextBoxId.Text.Trim(), TextBoxPassword.Text.Trim());

            if (userFound != null)
            {
                return userFound;
            }
            else
            {
                return null;
            }
        }


        private void SetCookie(string inlogId) //doto : legaal vragen of user cookies goedkeurd
        {
            HttpCookie cookie = new HttpCookie("SchoolLogin");
            cookie.Value = inlogId;
            cookie.Expires = DateTime.Now.AddHours(3);
            Response.SetCookie(cookie);
        }

        protected void ButtonLogin_Click1(object sender, EventArgs e)
        {
            if (ValidUser() != null)
            {
                Session["user"] = TextBoxId.Text.Trim();
                SetCookie(TextBoxId.Text.Trim());
                Response.Redirect("default.aspx");
            }
            else
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = "Authentication failed";
            }
        }
    }
}