using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClassOrganistation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            if (!Page.IsPostBack)
            {
                ListBoxStudent.Items.AddRange(getStudents().ToArray());
                DropDownListClass.Items.AddRange(getSchoolClasses().ToArray());
            }
        }

        protected void ButtonAddStudentToClass_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = ListBoxStudent.SelectedItem;
                if (selectedItem != null)
                {
                    ListBoxSchoolClass.Items.Add(selectedItem);
                    ListBoxStudent.Items.Remove(selectedItem);
                    ListBoxStudent.ClearSelection();
                    ListBoxSchoolClass.ClearSelection();
                }
            }
            catch (Exception oEx)
            {
                var message = oEx.Message;
                throw;
            }
        }

        protected void ButtonRemoveStudentFromClass_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = ListBoxSchoolClass.SelectedItem;
                if (selectedItem != null)
                {
                    ListBoxStudent.Items.Add(selectedItem);
                    ListBoxSchoolClass.Items.Remove(selectedItem);
                    ListBoxSchoolClass.ClearSelection();
                    ListBoxStudent.ClearSelection();
                }
            }
            catch (Exception oEx)
            {
                var message = oEx.Message;
                throw;
            }
        }

        private List<ListItem> getStudents()
        {
            var students = new List<ListItem>()
                {
                    new ListItem
                    {
                        Value = "1",
                        Text = "koen verboven"
                    },
                    new ListItem
                    {
                        Value = "2",
                        Text = "maria poels"
                    },
                    new ListItem
                    {
                        Value = "3",
                        Text = "janssens paul1"
                    },
                };
            return students;
        }

        private List<ListItem> getSchoolClasses()
        {
            var schoolClasses = new List<ListItem>()
                {
                    new ListItem
                    {
                        Value = "1",
                        Text = "4F1"
                    },
                    new ListItem
                    {
                        Value = "2",
                        Text = "4F2"
                    },
                    new ListItem
                    {
                        Value = "3",
                        Text = "4F3"
                    },

                };
            return schoolClasses;   
        }

    }
}