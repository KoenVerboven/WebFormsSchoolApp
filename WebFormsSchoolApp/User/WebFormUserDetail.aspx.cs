using Antlr.Runtime.Misc;
using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Security.Cryptography.X509Certificates;


namespace WebFormsSchoolApp.User
{
    public partial class WebFormUserDetail : System.Web.UI.Page
    {
        int userId = 0; // todo underscore _personid
        const string subject = "User";

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = string.Empty;

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    userId = Convert.ToInt32(Request.QueryString["userId"]);
                    action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;
                    if (action == "detail" || action == "update")
                    {
                        UserBLL userBLL = new UserBLL();
                        var userSelected = userBLL.GetUserById(userId);

                        LabelUserIdValue.Text = userSelected.UserId.ToString();
                        TextBoxUserName.Text = userSelected.UserName.ToString();
                        TextBoxActiveFrom.Text = userSelected.ActiveFrom.ToString();
                        CheckBoxBlocked.Checked = userSelected.Blocked;
                    }

                    switch (action)
                    {
                        case "detail":
                            LabelTitle.Text = subject +"Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        default:
                            LabelTitle.Text = subject + "Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ButtonSaveAndCancelVisible(bool visible)
        {
            ButtonSave.Visible = visible;
            ButtonCancel.Visible = visible;
        }

        private void DisableAllControls(bool disable)
        {
            var enableControl = !disable;
            TextBoxUserName.Enabled = enableControl;
            TextBoxActiveFrom.Enabled = enableControl;
            CheckBoxBlocked.Enabled = enableControl;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (SaveData())
                {
                    Response.Redirect("WebFormSearchUser.aspx");
                }
            }
        }


        private bool SaveData()
        {
            bool succes = false;
            UserBLL userBLL = new UserBLL();

            var user = new SchoolappBackend.BLL.models.User()
            {
                UserId = Convert.ToInt32(LabelUserIdValue.Text),
                UserName = TextBoxUserName.Text.Trim(),
                ActiveFrom = DateTime.Now, //todo Active From
                Blocked = CheckBoxBlocked.Checked 
            };

            if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
            {
                succes = userBLL.Update(user);
            }

            if (HiddenFieldAction.Value == "insert") //todo rplc string action in to enum
            {
                succes = userBLL.Add(user);
            }

            return succes;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchUser.aspx");
        }
    }
}