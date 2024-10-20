using SchoolappBackend.BLL.BLLClasses;
using System;

namespace WebFormsSchoolApp.Course
{
    public partial class WebFormCourseDetail : System.Web.UI.Page
    {
        //todo start date en stopdate in de database verplicht maken
        protected void Page_Load(object sender, EventArgs e)
        {
            int courseId = 0;
            string action = string.Empty;
            const string subject = "Course";

            CheckBoxActive.Enabled = false;
            
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
                    HiddenFieldAction.Value = action;

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
                        TextBoxCoursePrice.Text = Convert.ToString(courseSelected.CoursePrice);//todo :"€ "
                        TextBoxMinimumGradeToPassTheCourse.Text = Convert.ToString(courseSelected.MinimumGradeToPassTheCourse);
                        TextBoxMaximumTestCourseGrade.Text = Convert.ToString(courseSelected.MaximumTestCourseGrade);
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
            TextBoxCoursePrice.Enabled = enableControl;
            TextBoxMinimumGradeToPassTheCourse.Enabled = enableControl; 
            TextBoxMaximumTestCourseGrade.Enabled = enableControl;
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

            var courseId = 0;
            if (HiddenFieldAction.Value == "update")
            {
                courseId = Convert.ToInt32(LabelCourseIdValue.Text.Trim());
            }

            decimal? coursePrice = null;
            if(TextBoxCoursePrice.Text.Trim() != string.Empty)
            {
                coursePrice = Convert.ToDecimal(TextBoxCoursePrice.Text.Trim());
            };

            var course = new SchoolappBackend.BLL.models.Course()
            {
                CourseId = courseId,
                CourseName = TextBoxCourseName.Text.Trim(),
                CourseDescription = TextBoxCourseDescription.Text.Trim(),
                StartDate = Convert.ToDateTime(TextBoxStartDate.Text.Trim()),
                EndDate = Convert.ToDateTime(TextBoxEndDate.Text.Trim()),
                CourseType = SchoolappBackend.BLL.models.CourseType.DaySchool,//todo CourseType
                CoursePrice = coursePrice,
                MinimumGradeToPassTheCourse = Convert.ToDouble(TextBoxMinimumGradeToPassTheCourse.Text.Trim()),
                MaximumTestCourseGrade = Convert.ToInt32(TextBoxMaximumTestCourseGrade.Text.Trim())
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