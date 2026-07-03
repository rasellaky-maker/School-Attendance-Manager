namespace SAM.Core.Enums
{
    public enum Status
    {
        Unknown = 0,

        Present,      // присутствует
        Absent,       // отсутствует (причина неизвестна)
        Excused,      // отсутствует по уважительной причине
        Late          // опоздал
    }
}
