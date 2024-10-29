using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClassOrganistation : System.Web.UI.Page
    {
        List<SchoolappBackend.BLL.models.Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            if (!Page.IsPostBack)
            {
                ListBoxStudent.DataSource = SearchStudents("", "LastName");
                ListBoxStudent.DataValueField = "PersonId";
                ListBoxStudent.DataTextField = "FullName";
                ListBoxStudent.DataBind();
                
                DropDownListClass.Items.AddRange(getSchoolClasses().ToArray());
            }
        }

        private List<SchoolappBackend.BLL.models.Student> SearchStudents(string search,string orderBy)
        {
            StudentBLL studentBLL = new StudentBLL();
            students = studentBLL.GetStudents(search, orderBy,"ASC");
            return students;
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

        [Obsolete]
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