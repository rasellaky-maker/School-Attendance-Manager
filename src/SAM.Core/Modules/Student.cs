using SAM.Core.Enums;
using System.Runtime.InteropServices;
using System.Text;

namespace SAM.Core.Modules
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolClassId { get; set; }
        public Status Status { get; set; }

        public Student(int id, string firstName, string lastName, int schoolClassId, Status status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SchoolClassId = schoolClassId;
            Status = status;
        }

        public Student(string firstName, string lastName, int schoolClassId, Status status):this(0, firstName, lastName, schoolClassId, status)
        { }
        public Student()
        { }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({Status.ToString()})";
        }
        public string GetFullName()
        {
            return $"{LastName} {FirstName}";
        }
        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Students_ID: " + Id);
            sb.AppendLine("Firstname: " + FirstName);
            sb.AppendLine("Lastname: " + LastName);
            sb.AppendLine("Class_ID: " + SchoolClassId);
            sb.Append("Status: " + Status.ToString());

            return sb.ToString();
        }
    }
}
