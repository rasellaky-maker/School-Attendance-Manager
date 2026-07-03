using SAM.Core.Enums;

namespace SAM.Core.Modules
{
    public class AbsenceNote
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public AbsenceReason Reason { get; set; }
        public string Comment { get; set; }

        public AbsenceNote(int id, int studentId, DateTime date, AbsenceReason reason, string comment)
        {
            Id = id;
            StudentId = studentId;
            Date = date;
            Reason = reason;
            Comment = comment;
        }
        public AbsenceNote(int id, int studentId, DateTime date, AbsenceReason reason):this(id, studentId, date, reason, "")
        { }
        public AbsenceNote(int studentId, DateTime date, AbsenceReason reason, string comment):this(0, studentId, date, reason, comment) 
        { }
        public AbsenceNote(int studentId, DateTime date, AbsenceReason reason) : this(0, studentId, date, reason, "")
        { }
        public AbsenceNote() 
        { }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Comment))
                return $"{StudentId} ({Date.ToString("dd.MM.yyyy")}) => {Reason.ToString()}";
            return $"{StudentId} ({Date.ToString("dd.MM.yyyy")}) => {Reason.ToString()} + {Comment}";
        }

        public string GetSummary()
        {
            return $"{Reason.ToString()} {Date.ToString("dd.MM.yyyy")}";
        }

        public string GetDetails()
        {
            return $"{Id}/{StudentId} ({Date.ToString("dd.MM.yyyy")}) => {Reason.ToString()} [{Comment}]";
        }

        public bool Validate()
        {
            if (Id <= 0)
                return false ;
            if (StudentId <= 0)
                return false ;
            if (Date == default)
                return false ;
            if (Reason == AbsenceReason.Unknown)
                return false ;

            return true ;
        }
        public bool IsExcused()
        {
            if (Reason == AbsenceReason.Excused)
                return true ;
            return false ;
        }
    }
}
