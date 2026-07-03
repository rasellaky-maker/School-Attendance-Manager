namespace SAM.Core.Enums
{
    public enum AbsenceReason
    {
        Unknown = 0,

        Illness,              // Болезнь
        MedicalAppointment,   // Посещение врача
        FamilyReason,         // Семейные обстоятельства
        PersonalReason,       // Личные обстоятельства
        ExcusedByParent,      // По заявлению родителей
        SchoolActivity,       // Школьное мероприятие (олимпиада, соревнования и т.п.)
        Competition,          // Спортивные соревнования
        Vacation,             // Семейный отпуск
        TransportIssue,       // Проблемы с транспортом
        WeatherConditions,    // Плохие погодные условия
        Unexcused,            // Без уважительной причины
        Excused,              // Извенино
        Other                 // Другое
    }
}
