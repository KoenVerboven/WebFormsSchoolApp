using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Drawing;
using WebFormsSchoolApp.App_Code;

namespace WebFormsSchoolApp.Settings
{
    enum ShowMessageType
    {
        normal,
        warning,
        error
    }
    
    
    public partial class WebFormChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
        }

        protected void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            string userName =  Convert.ToString(Session["user"]);
            string newPassword = TextBoxNew.Text.Trim();

            try
            {
                if(newPassword.Length > 7)
                {
                    var userBLL = new UserBLL();
                    var succes = userBLL.UpdatePassword(Helper.ComputeHash(newPassword, "SHA512", null), userName);

                    if (succes)
                    {
                        ShowMessage("New password is succesfull updated.", ShowMessageType.normal);
                        TextBoxCurrent.Text = string.Empty;
                        TextBoxNew.Text = string.Empty;
                        TextBoxConfirmPassword.Text = string.Empty;
                    }

                }
               
            }
            catch (Exception oEx)
            {
                ShowMessage(oEx.Message,ShowMessageType.error);
            }
        }

        private void ShowMessage(string message, ShowMessageType showMessageType)
        {
            LabelMessage.Text = message;
            LabelMessage.Visible = true;
        
            if(showMessageType == ShowMessageType.normal)
            {
                LabelMessage.ForeColor = Color.Black; //todo : change css class insteat of this line
                LabelMessage.BackColor = Color.FromArgb(171, 170, 230);
            }

            if (showMessageType == ShowMessageType.error)
            {
                LabelMessage.ForeColor = Color.Black;
                LabelMessage.BackColor = Color.FromArgb(255, 140, 137);
            }
        }
    }
}