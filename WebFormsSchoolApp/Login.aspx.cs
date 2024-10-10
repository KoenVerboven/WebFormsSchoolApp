using System;

namespace WebFormsSchoolApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LabelUserId.ForeColor = System.Drawing.Color.White;
            //LabelPassword.ForeColor = System.Drawing.Color.White;
            LabelMessage.ForeColor = System.Drawing.Color.Red;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (TextBoxId.Text == "admin" && TextBoxPassword.Text == "admin")
            if (TextBoxId.Text == "admin" || TextBoxId.Text == "koen" || TextBoxId.Text == "johan")
            {
                Session["user"] = TextBoxId.Text.Trim();
                Response.Redirect("MainForm.aspx");
            }
            else
            {
                LabelMessage.Text = "UserId or password is not valid";
            }
        }
    }
}