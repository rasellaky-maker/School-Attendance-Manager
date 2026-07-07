using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SAM.Core.Modules
{
    public class ClassLeader : User
    {
        public int SchoolClassId { get; set; }
        public DateTime ClassLeaderEndDate { get; set; }
        public ClassLeader(int id, string firstName, string lastName, string username, string passHash, string passSalt, int schoolClassId, DateTime classLeaderEndDate) : base(id, firstName, lastName, username, passHash, passSalt)
        {
            SchoolClassId = schoolClassId;
            ClassLeaderEndDate = classLeaderEndDate;
        }
        public ClassLeader(string firstName, string lastName, string username, string passHash, string passSalt, int schoolClassId, DateTime classLeaderEndDate) : this(0, firstName, lastName, username, passHash, passHash, schoolClassId, classLeaderEndDate)
        { }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class Leader");
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Name: {LastName} {FirstName}");
            sb.AppendLine($"Username: {Username}");
            sb.AppendLine($"Class_Id: {SchoolClassId}");
            sb.AppendLine($"Class_Leader_End_Date: {ClassLeaderEndDate.ToString("dddd.MM.yyyy")}");

            return sb.ToString();
        }

        public bool IsValidate()
        {
            if (SchoolClassId <= 0)
                return false;
            if (Id <= 0)
                return false;
            if (string.IsNullOrWhiteSpace(Username))
                return false;
            if (string.IsNullOrWhiteSpace(FirstName))
                return false;
            if (string.IsNullOrWhiteSpace(LastName))
                return false;
            if (ClassLeaderEndDate < DateTime.Now)
                return false;

            return true;
        }
    }
}
