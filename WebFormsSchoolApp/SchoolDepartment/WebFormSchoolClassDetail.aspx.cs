using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Web.UI;



namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClassDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int schoolClassId = 0;
            string action = string.Empty;
            const string subject = "SchoolClass";


            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    schoolClassId = Convert.ToInt32(Request.QueryString["schoolClassId"]);
                    action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;

                    if (action == "detail" || action == "update")
                    {
                        FillInControls(schoolClassId);  
                    }

                    switch (action)
                    {
                        case "detail":
                            LabelTitle.Text = subject + " Detail";
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
                            LabelTitle.Text = subject + " Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                LabelErrorMessage.Text = "An error occured.Try later again.";
            }
        }

        private void FillInControls(int schoolClassId)
        {
            var schoolDepartmentBLL = new SchoolDepartmentBLL();
            // var schoolClassSelected = schoolDepartmentBLL.
           
            //var courseSelected = courseBLL.GetCourseById(courseId);

            //LabelCourseIdValue.Text = Convert.ToString(courseSelected.CourseId);
            //TextBoxCourseName.Text = courseSelected.CourseName;
        }



        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (SaveData())
                {
                    Response.Redirect("WebFormSearchCourse.aspx");
                }
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
           // TextBoxCourseName.Enabled = enableControl;
        
        }




        private bool SaveData()
        {
            return true;
            
            //bool succes = false;
            //CourseBLL courseBLL = new CourseBLL();

            //var courseId = 0;
            //if (HiddenFieldAction.Value == "update")
            //{
            //    courseId = Convert.ToInt32(LabelCourseIdValue.Text.Trim());
            //}

            

            //var course = new SchoolappBackend.BLL.models.Course()
            //{
            //    CourseId = courseId,
            //    CourseName = TextBoxCourseName.Text.Trim(),
           
            //};

            //if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
            //{
            //    succes = courseBLL.Update(course);
            //}

            //if (HiddenFieldAction.Value == "insert") //todo rplc string action in to enum
            //{
            //    succes = courseBLL.Add(course);
            //}
            //return succes;
        }



        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSchoolClass.aspx");
        }
    }
}