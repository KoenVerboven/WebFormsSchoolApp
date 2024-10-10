﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.Course
{
    public partial class FormSearchCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                GridView1.DataSource = courses;
                GridView1.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridView1_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
                //e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                //e.Row.ToolTip = "Click to select row"; e.Row.Attributes["onclick"] = Response.Redirect("");
                //e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    Response.Redirect("FormCourseDetail.aspx?CourseId=" + row.Cells[1].Text.Trim());
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}