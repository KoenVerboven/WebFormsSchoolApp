using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolappBackend.BLL.BLLClasses
{
    public  class StudentBLL : IStudentBLL
    {
        List<Student> students;

        public StudentBLL()
        {
            students = new List<Student>();
            FillStudentlist();

        }

        public bool AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(string searchField,string orderBy)
        {
            if (students != null)
            {
                students = students
                             .Where(X => X.FullName.ToLower().Contains(searchField.ToLower())
                                       )
                             .OrderBy(x => x.DateOfBirth)
                            .ToList();

                switch (orderBy)
                {
                    case "PersonId":
                        students = students.OrderBy(x => x.PersonId).ToList();
                        break;
                    case "FullName":
                        students = students.OrderBy(x => x.FullName).ToList();
                        break;
                    case "DateOfBirth":
                        students = students.OrderBy(x => x.DateOfBirth).ToList();
                        break;
                    default:
                        students = students.OrderBy(x => x.PersonId).ToList();
                        break;
                }
                return students;
            }
            return null;
        }

        public bool UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        private void FillStudentlist()
        {
            students = new List<models.Student>()
            {
                new models.Student{
                    PersonId = 1,
                    LastName = "Poels",
                    Firstname = "Maria",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1974,4,12),
                    RegistrationDate = new DateTime(2023,8,1),
                },
                new models.Student{
                    PersonId = 2,
                    LastName = "Verboven",
                    Firstname = "Johan",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1999,1,31),
                    RegistrationDate = new DateTime(2023,8,5),
                },
                new models.Student{
                    PersonId = 3,
                    LastName = "Verboven",
                    Firstname = "Koen",
                    MiddleName = "Frans Maria",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1966,6,1),
                    RegistrationDate = new DateTime(2023,8,9),
                },
                new models.Student{
                    PersonId = 4,
                    LastName = "Peeters",
                    Firstname = "Jos",
                    MiddleName = "",
                    StreetAndNumber ="Kerkstraat 13",
                    ZipCode = "5200",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2002,3,13),
                    RegistrationDate = new DateTime(2023,8,13),
                },
                new models.Student{
                    PersonId = 5,
                    LastName = "Gevers",
                    Firstname = "An",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 14",
                    ZipCode = "6000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2000,1,3),
                    RegistrationDate = new DateTime(2024,7,15),
                },
                new models.Student{
                    PersonId = 6,
                    LastName = "Pieters",
                    Firstname = "Mark",
                    MiddleName = "",
                    StreetAndNumber ="Fazantenlaan 4",
                    ZipCode = "9000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1995,9,1),
                    RegistrationDate = new DateTime(2024,7,16),
                },
                new models.Student{
                    PersonId = 7,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    MiddleName = "",
                    StreetAndNumber ="Koolhof 45a",
                    ZipCode = "4500",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1986,3,3),
                    RegistrationDate = new DateTime(2024,6,30),
                },

                new models.Student{
                    PersonId = 8,
                    LastName = "Vertonghen",
                    Firstname = "Mark",
                    MiddleName = "",
                    StreetAndNumber ="Koolhof 46a",
                    ZipCode = "3000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1987,4,2),
                    RegistrationDate = new DateTime(2024,6,29),
                },
                new models.Student{
                    PersonId = 9,
                    LastName = "Van De Veire",
                    Firstname = "Els",
                    MiddleName = "",
                    StreetAndNumber ="Berkenhei 1",
                    ZipCode = "4000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1977,6,12),
                    RegistrationDate = new DateTime(2024,6,22),
                },
                new models.Student{
                    PersonId = 10,
                    LastName = "Grootjans",
                    Firstname = "Jose",
                    MiddleName = "",
                    StreetAndNumber ="Grotebaan 48a",
                    ZipCode = "4000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1965,5,12),
                    RegistrationDate = new DateTime(2024,7,24),
                },
                 new models.Student{
                    PersonId = 11,
                    LastName = "Dhondt",
                    Firstname = "Sean",
                    MiddleName = "",
                    StreetAndNumber ="Antwerpsesteenweg 455",
                    ZipCode = "9000",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2004,4,22),
                    RegistrationDate = new DateTime(2024,7,15),
                },
                new models.Student{
                    PersonId = 12,
                    LastName = "Huisman",
                    Firstname = "Josje",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 1",
                    ZipCode = "5444",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2001,3,4),
                    RegistrationDate = new DateTime(2024,7,16),
                },
                new models.Student{
                    PersonId = 13,
                    LastName = "Brusselmans",
                    Firstname = "Jan",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 45",
                    ZipCode = "2330",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(2003,4,7),
                    RegistrationDate = new DateTime(2024,8,5),
                },
                new models.Student{
                    PersonId = 14,
                    LastName = "van Aert",
                    Firstname = "Wout",
                    MiddleName = "",
                    StreetAndNumber ="Cingel 78",
                    ZipCode = "2300",
                    PhoneNumber = "6468468",
                    EmailAddress = "@test.be",
                    DateOfBirth = new DateTime(1974,9,12),
                    RegistrationDate = new DateTime(2024,9,6)
                },
            };
        }

    }
}
