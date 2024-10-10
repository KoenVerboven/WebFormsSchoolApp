
namespace WebFormsSchoolApp.models
{
    public class Person
    {
        public int PersonId { get; set; }
        public  string Firstname { get; set; }
       // public string? MiddleName { get; set; }
        public  string LastName { get; set; }
        public string FullName { get => LastName + " " + Firstname; }
        //public required string StreetAndNumber { get; set; }
        //public required string ZipCode { get; set; }
        //public string? PhoneNumber { get; set; }
        //public string? EmailAddress { get; set; }
        //public Gender Gender { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public MaritalStatus MaritalStatus { get; set; }
        //public int NationalRegisterNumber { get; set; }
        //public Nationality Nationality { get; set; }
        //public int MoederTongueId { get; set; }
    }
}
