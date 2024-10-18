using SchoolappBackend.BLL.BLLClasses;
using System;

namespace WebFormsSchoolApp.Course
{
    public partial class WebFormCourseDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int courseId = 0;
            string action = string.Empty;

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    courseId = Convert.ToInt32(Request.QueryString["courseId"]);
                    action = Request.QueryString["action"];

                    if (action == "detail" || action == "update")
                    {
                        CourseBLL courseBLL = new CourseBLL();
                        var courseSelected = courseBLL.GetCourseById(courseId);

                        LabelCourseIdValue.Text = Convert.ToString(courseSelected.CourseId);
                        TextBoxCourseName.Text = courseSelected.CourseName;
                        TextBoxCourseDescription.Text = courseSelected.CourseDescription;
                        TextBoxStartDate.Text = courseSelected.StartDate.ToString("dd-MM-yyyy");
                        TextBoxEndDate.Text = courseSelected.EndDate.ToString("dd-MM-yyyy");
                        CheckBoxActive.Checked = courseSelected.CourseIsActive;
                        TextBoxCoursePrice.Text = "€ " + Convert.ToString(courseSelected.CoursePrice);
                    }

                    switch (action)
                    {
                        case "detail":
                            LabelTitle.Text = "Course Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new Course";
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update Course";
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        default:
                            LabelTitle.Text = "Course Detail";
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

        private void ButtonSaveAndCancelVisible(bool visible)
        {
            ButtonSave.Visible = visible;
            ButtonCancel.Visible = visible;
        }


        private void DisableAllControls(bool disable)
        {
            var enableControl = !disable;
            TextBoxCourseName.Enabled = enableControl;
            TextBoxCourseDescription.Enabled = enableControl;
            TextBoxStartDate.Enabled = enableControl;
            TextBoxEndDate.Enabled = enableControl;
            CheckBoxActive.Enabled = enableControl;
            TextBoxCoursePrice.Enabled = enableControl;
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


        private bool SaveData()
        {
            bool succes = false;
            CourseBLL courseBLL = new CourseBLL();

            var course = new SchoolappBackend.BLL.models.Course()
            {
                CourseId = Convert.ToInt32(LabelCourseIdValue.Text),
                CourseName = TextBoxCourseName.Text.Trim(),
                CourseDescription = TextBoxCourseDescription.Text.Trim(),
                StartDate = Convert.ToDateTime(TextBoxStartDate.Text.Trim()),
                EndDate = Convert.ToDateTime(TextBoxEndDate.Text.Trim()),
                CourseType = SchoolappBackend.BLL.models.CourseType.DaySchool,//todo CourseType
                CoursePrice = Convert.ToDecimal(TextBoxCoursePrice.Text.Trim())
            };

            if (HiddenFieldAction.Value == "update") //todo rplc string action in to enum
            {
                succes = courseBLL.Update(course);
            }

            if (HiddenFieldAction.Value == "insert") //todo rplc string action in to enum
            {
                succes = courseBLL.Add(course);
            }
            return succes;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchCourse.aspx");
        }
    }
}