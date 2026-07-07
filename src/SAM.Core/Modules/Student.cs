using SAM.Core.Enums;
using System.Text;

namespace SAM.Core.Modules
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolClassId { get; set; }
        public bool IsAbsence { get; set; }
        public Status Status { get; set; }

        public Student(int id, string firstName, string lastName, int schoolClassId, bool isAbsence, Status status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SchoolClassId = schoolClassId;
            IsAbsence = isAbsence;
            Status = status;
        }

        public Student(string firstName, string lastName, int schoolClassId, bool isAbsence, Status status) : this(0, firstName, lastName, schoolClassId, isAbsence, status)
        { }
        public Student()
        { }

        public override string ToString()
        {
            var absenceStatus = IsAbsence ? "Absent" : "Present";
            return $"{LastName} {FirstName} - {absenceStatus} ({Status.ToString()})";
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
            sb.AppendLine("Absence: " + IsAbsence.ToString());
            sb.Append("Status: " + Status.ToString());

            return sb.ToString();
        }
    }
}
