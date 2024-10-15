﻿using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolappBackend.BLL.BLLClasses
{
    public class TeacherBLL : ITeacherBLL
    {
        List<Teacher> teachers;

        public TeacherBLL()
        {
            teachers = new List<Teacher>();
            FillTeachersList();
        }

        public Teacher GetTeacherById(int Id)
        {
            return teachers.SingleOrDefault(p => p.PersonId == Id);
        }

        public List<Teacher> GetTeachers(string searchField, string orderBy)
        {
            if (teachers != null)
            {
                teachers = teachers
                             .Where(X => X.FullName.ToLower().Contains(searchField.ToLower())
                                       ).ToList();

                switch (orderBy)
                {
                    case "PersonId":
                        teachers = teachers.OrderBy(x => x.PersonId).ToList();
                        break;
                    case "FullName":
                        teachers = teachers.OrderBy(x => x.FullName).ToList();
                        break;
                    case "DateOfBirth":
                        teachers = teachers.OrderBy(x => x.DateOfBirth).ToList();
                        break;
                    default:
                        teachers = teachers.OrderBy(x => x.PersonId).ToList();
                        break;
                }
                return teachers;
            }
            return null;
        }

        private void FillTeachersList()
        {
            teachers = new List<models.Teacher>()
            {
                new models.Teacher{
                    PersonId = 1,
                    LastName = "Verstraaten",
                    Firstname = "Danny",
                    MiddleName = "",
                    StreetAndNumber ="Grote Weg 441",
                    ZipCode = "3000",
                    PhoneNumber = "2782578528",
                    EmailAddress = "Danny@test.be",
                    DateOfBirth = new DateTime(1980,4,15),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.A1,
                    SeniorityYears = 1
                },
                new models.Teacher{
                    PersonId = 2,
                    LastName = "Vervoort",
                    Firstname = "Els",
                    MiddleName = "",
                    StreetAndNumber ="Beersebaan 33",
                    ZipCode = "4000",
                    PhoneNumber = "23783287468",
                    EmailAddress = "Els@test.be",
                    DateOfBirth = new DateTime(1999,4,12),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.C1,
                    SeniorityYears = 6
                },
                new models.Teacher{
                    PersonId = 3,
                    LastName = "Michiels",
                    Firstname = "Peter",
                    MiddleName = "",
                    StreetAndNumber ="Mpad 33",
                    ZipCode = "2300",
                    PhoneNumber = "6258527468",
                    EmailAddress = "Peter@test.be",
                    DateOfBirth = new DateTime(1982,3,2),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.A2,
                    SeniorityYears = 4
                },
                new models.Teacher{
                    PersonId = 4,
                    LastName = "Neutenboom",
                    Firstname = "Pascal",
                    MiddleName = "",
                    StreetAndNumber ="Turnhoutsebaan 33",
                    ZipCode = "4000",
                    PhoneNumber = "6463653868",
                    EmailAddress = "Peter@test.be",
                    DateOfBirth = new DateTime(2005,3,2),
                    HireDate = DateTime.Now,
                    SaleryCategorie = models.SaleryCategorie.C1,
                    SeniorityYears = 12
                },
            };
        }
    }
}