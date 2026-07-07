using SAM.Core.Enums;
using System.Text;

namespace SAM.Core.Modules
{
    public class HomeroomTeacher : User
    {
        public int SchoolClassId { get; set; }
        public AcademicTitle Title { get; set; }

        public HomeroomTeacher(int id, string firstName, string lastName, string username, string passHash, string passSalt, int schoolClassId, AcademicTitle academicTitle) : base(id, firstName, lastName, username, passHash, passSalt)
        {
            SchoolClassId = schoolClassId;
            Title = academicTitle;
        }
        public HomeroomTeacher(string firstName, string lastName, string username, string passHash, string passSalt, int schoolClassId, AcademicTitle academicTitle) : this(0, firstName, lastName, username, passHash, passSalt, schoolClassId, academicTitle)
        { }
        public HomeroomTeacher()
        { }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Homeroom Teacher");
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Name: {Title}. {FirstName} {LastName}");
            sb.AppendLine($"Username: {Username}");
            sb.AppendLine($"Class_Id: {SchoolClassId}");
            return sb.ToString();
        }
    }
}
