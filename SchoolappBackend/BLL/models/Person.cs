using System;


namespace SchoolappBackend.BLL.models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => LastName + "  (" + MiddleName + ") " + Firstname; }
        public string StreetAndNumber { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MaritalStatus { get; set; }
        public string NationalRegisterNumber { get; set; }
        public int Nationality { get; set; }
    }
}
