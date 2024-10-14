using System;
using System.Collections.Generic;
using System.Linq;

namespace WebFormsSchoolApp.Course
{
    public partial class WebFormCourseDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int courseId = 0;
            string action = string.Empty;

            var courses = new List<models.Course>()
            {
                new models.Course{
                    CourseId = 1,
                    CourseName = "piano",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2022, 5, 2),
                    EndDate =  new DateTime(2025, 9, 4),
                    CoursePrice = 45.9m,
                    CourseType = models.CourseType.DaySchool
                },
                new models.Course{
                    CourseId = 2,
                    CourseName = "guitar",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2022, 9, 1),
                    EndDate =  new DateTime(2024, 2, 5),
                    CoursePrice = 99.99m,
                    CourseType = models.CourseType.DaySchool
                },
                new models.Course{
                    CourseId = 3,
                    CourseName = "recorder",
                    CourseDescription= "gevorderde lessen",
                    StartDate =  new DateTime(2022, 3, 12),
                    EndDate =  new DateTime(2023, 3, 1),
                    CoursePrice = 99m,
                    CourseType = models.CourseType.DaySchool
                },
                new models.Course{
                    CourseId = 4,
                    CourseName = "bass guitar",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2022, 6, 12),
                    EndDate =  new DateTime(2025, 5, 4),
                    CoursePrice = 101.99m,
                    CourseType = models.CourseType.DaySchool
                },
                 new models.Course{
                    CourseId = 5,
                    CourseName = "singing",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2022, 7, 24),
                    EndDate =  new DateTime(2026, 4, 3),
                    CoursePrice = 100m,
                    CourseType = models.CourseType.WeekendSchool
                },
                 new models.Course{
                    CourseId = 6,
                    CourseName = "trumpet",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2022, 4, 25),
                    EndDate =  new DateTime(2023, 1, 15),
                    CoursePrice = 50m,
                    CourseType = models.CourseType.NightSchool
                },
                new models.Course{
                    CourseId = 7,
                    CourseName = "drum",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2021, 4, 26),
                    EndDate =  new DateTime(2023, 10, 17),
                    CoursePrice = 45m,
                    CourseType = models.CourseType.DaySchool
                },
                new models.Course{
                    CourseId = 8,
                    CourseName = "trumpet",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2022, 2, 27),
                    EndDate =  new DateTime(2022, 12, 18),
                    CoursePrice = 12m,
                    CourseType = models.CourseType.NightSchool
                },
                new models.Course{
                    CourseId = 9,
                    CourseName = "saxophone",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2023, 3, 29),
                    EndDate =  new DateTime(2024, 3, 25),
                    CoursePrice = 99.9m,
                    CourseType = models.CourseType.WeekendSchool
                },
                new models.Course{
                    CourseId = 10,
                    CourseName = "drum",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2023, 4, 21),
                    EndDate =  new DateTime(2024, 4, 24),
                    CoursePrice = 10m,
                    CourseType = models.CourseType.DaySchool
                },
                 new models.Course{
                    CourseId = 11,
                    CourseName = "electric guitar",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2021, 7, 15),
                    EndDate =  new DateTime(2023, 10, 30),
                    CoursePrice = 30m,
                    CourseType = models.CourseType.WeekendSchool
                },
                new models.Course{
                    CourseId = 12,
                    CourseName = "synthesizer",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2023, 12, 14),
                    EndDate =  new DateTime(2027, 12, 13),
                    CoursePrice = 99m,
                    CourseType = models.CourseType.DaySchool
                },
                 new models.Course{
                    CourseId = 13,
                    CourseName = "harp",
                    CourseDescription= "junior",
                    StartDate =  new DateTime(2024, 6, 13),
                    EndDate =  new DateTime(2034, 3, 12),
                    CoursePrice = 200m,
                    CourseType = models.CourseType.NightSchool
                },
                new models.Course{
                    CourseId = 14,
                    CourseName = "harp",
                    CourseDescription= "senior",
                    StartDate =  new DateTime(2025, 5, 5),
                    EndDate =  new DateTime(2044, 4, 15),
                    CoursePrice = 250m,
                    CourseType = models.CourseType.NightSchool
                },
            };

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
                        var courseSelected = courses.SingleOrDefault(p => p.CourseId == courseId);
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
                //save
            }
            else
            {
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSearchCourse.aspx");
        }
    }
}