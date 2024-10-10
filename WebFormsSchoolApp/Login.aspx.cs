using System;

namespace WebFormsSchoolApp
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = System.Drawing.Color.Red;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
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