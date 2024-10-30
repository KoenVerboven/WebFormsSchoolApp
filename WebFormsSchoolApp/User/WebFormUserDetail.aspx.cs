using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;


namespace WebFormsSchoolApp.User
{
    public partial class WebFormUserDetail : System.Web.UI.Page
    {
        int userId = 0; // todo underscore _personid
        const string subject = "User";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                
                    LabelMessage.Visible = false;
                    userId = Convert.ToInt32(Request.QueryString["userId"]);
                    string action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;
                   
                    DropDownListUserRole.Items.AddRange(getUserRoles().ToArray());

                    if (action == "detail" || action == "update")
                    {
                        UserBLL userBLL = new UserBLL();
                        var userSelected = userBLL.GetUserById(userId);

                        LabelUserIdValue.Text = userSelected.UserId.ToString();
                        TextBoxUserName.Text = userSelected.UserName.ToString();
                        TextBoxActiveFrom.Text = userSelected.ActiveFrom.ToString();
                        CheckBoxBlocked.Checked = userSelected.Blocked;
                        DropDownListUserRole.SelectedValue = Convert.ToString(userSelected.UserRoleId);
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
            DropDownListUserRole.Enabled = enableControl;
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
            var userId = 0;

            try
            {
                if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
                {
                    userId = Convert.ToInt32(LabelUserIdValue.Text);
                }

                var user = new SchoolappBackend.BLL.models.User()
                {
                    UserId = userId,
                    UserName = TextBoxUserName.Text.Trim(),
                    Password = "User@123",
                    UserRoleId = Convert.ToInt32(DropDownListUserRole.SelectedValue),
                    ActiveFrom = Convert.ToDateTime(TextBoxActiveFrom.Text.Trim()),
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
            }
            catch (Exception oEx)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = oEx.Message;
            }

            return succes;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchUser.aspx");
        }

        private List<ListItem> getUserRoles()
        {
            var userRoles = new List<ListItem>()
            {
                    new ListItem
                    {
                        Value = "0",
                        Text = ""
                    },
                    new ListItem
                    {
                        Value = "1",
                        Text = "Student"
                    },
                    new ListItem
                    {
                        Value = "2",
                        Text = "Parent"
                    },
                    new ListItem
                    {
                        Value = "3",
                        Text = "Teacher"
                    },
                    new ListItem
                    {
                        Value = "4",
                        Text = "Management"
                    },
                    new ListItem
                    {
                        Value = "5",
                        Text = "Administrator"
                    },
            };
            return userRoles;
        }
    }
}