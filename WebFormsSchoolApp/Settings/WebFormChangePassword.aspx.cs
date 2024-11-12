using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Drawing;
using System.Linq;
using WebFormsSchoolApp.App_Code;

namespace WebFormsSchoolApp.Settings
{
    
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
            string currentPassword = TextBoxCurrent.Text.Trim();   
            string confirmPassword = TextBoxConfirmPassword.Text.Trim();
            bool validationOk = true;

            try
            {
                if(newPassword.Length < 8 || newPassword.Length > 25)
                {
                    ShowMessage("New password must be minimum 8 and maximum 25 characters long.", ShowMessageType.error);
                    validationOk = false;
                }

                if(newPassword == currentPassword)
                {
                    ShowMessage("New password must be different form current password.", ShowMessageType.error);
                    validationOk = false;
                }

                if(newPassword != confirmPassword)
                {
                    ShowMessage("Confirm password must be equal to new password.", ShowMessageType.error);
                    validationOk = false;
                }

                if(!newPassword.Any(char.IsUpper))
                {
                    ShowMessage("New password must contain at lest 1 upper case letter.", ShowMessageType.error);
                    validationOk = false;
                }

                if (!newPassword.Any(char.IsLower))
                {
                    ShowMessage("New password must contain at lest 1 lower case letter.", ShowMessageType.error);
                    validationOk = false;
                }

                if (newPassword.Contains(" "))
                {
                    ShowMessage("New password may not contain white spaces.", ShowMessageType.error);
                    validationOk = false;
                }

                if(! ValidationUtilities.PasswordContainsAtLeast1SpecialChar(newPassword))
                {
                    ShowMessage("New password must contain at least 1 special character.", ShowMessageType.error);
                    validationOk = false;
                }

                if (validationOk)
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
                LabelMessage.BackColor = Color.FromArgb(155, 233, 145);
            }

            if (showMessageType == ShowMessageType.error)
            {
                LabelMessage.ForeColor = Color.Black;
                LabelMessage.BackColor = Color.FromArgb(255, 140, 137);
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Menus/WebFormSettingsMenu.aspx");
        }
    }
}