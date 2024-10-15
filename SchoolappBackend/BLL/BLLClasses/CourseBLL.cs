using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class CourseBLL : ICourseBLL
    {
        List<SchoolappBackend.BLL.models.Course> courses;

        public CourseBLL()
        {
            courses = new List<Course>();
            FillCoursesList();
        }

        public Course GetCourseById(int courseId)
        {
            return courses.SingleOrDefault(p => p.CourseId == courseId);
        }

        public List<Course> GetCourses(string searchField, string orderBy)
        {
            if (courses != null)
            {
                courses = courses
                             .Where(X => X.CourseName.ToLower().Contains(searchField.ToLower())
                ).ToList();


                //if (DropDownListFilterActive.Items.Count > 0)
                //{
                //    if (DropDownListFilterActive.SelectedItem.Text == "Show active") //todo ipv text -> value
                //    {
                //        courses = courses.Where(X => X.CourseIsActive == true).ToList();
                //    }
                //    if (DropDownListFilterActive.SelectedItem.Text == "Show non active") //todo ipv text -> value
                //    {
                //        courses = courses.Where(X => X.CourseIsActive == false).ToList();
                //    }
                //}
                //else
                //{
                //    courses = courses.Where(X => X.CourseIsActive == true).ToList();
                //}

                switch (orderBy)
                {
                    case "CourseId":
                        courses = courses.OrderBy(x => x.CourseId).ToList();
                        break;
                    case "CourseName":
                        courses = courses.OrderBy(x => x.CourseName).ToList();
                        break;
                    case "StartDate":
                        courses = courses.OrderByDescending(x => x.StartDate).ToList();
                        break;
                    case "EndDate":
                        courses = courses.OrderByDescending(x => x.EndDate).ToList();
                        break;
                    case "CourseType":
                        courses = courses.OrderBy(x => x.CourseType).ToList();
                        break;
                    case "CourseIsActive":
                        courses = courses.OrderBy(x => x.CourseIsActive).ToList();
                        break;
                    default:
                        courses = courses.OrderByDescending(x => x.StartDate).ToList();
                        break;
                }
                return courses;
            }
            return null;
        }

        public List<Course> GetCoursesByStudentId(int studentId)
        {
            throw new NotImplementedException();
        }

        private void FillCoursesList()
        {
            courses = new List<models.Course>()
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
        }
    }
}
