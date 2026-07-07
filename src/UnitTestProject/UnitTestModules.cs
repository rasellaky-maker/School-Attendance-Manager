using SAM.Core.Enums;
using SAM.Core.Modules;
using System.Diagnostics.Contracts;
using Xunit;

namespace UnitTestProject
{
    public class UnitTestModules
    {
        // ================================
        // MODULES : AbsenceNote
        // ================================
        [Fact]
        public void Test1()
        {
            AbsenceNote testNote = new AbsenceNote(1, Convert.ToDateTime("02.07.2026"), AbsenceReason.SchoolActivity);

            var result = testNote.ToString();

            Assert.Equal("1 (02.07.2026) => SchoolActivity", result);
        }

        [Fact]
        public void Test2()
        {
            AbsenceNote testNote = new AbsenceNote(1, Convert.ToDateTime("02.07.2026"), AbsenceReason.MedicalAppointment);

            var result = testNote.GetSummary();

            Assert.Equal("MedicalAppointment 02.07.2026", result);
        }

        [Fact]
        public void Test3()
        {
            var testNote = new AbsenceNote(1, 1, Convert.ToDateTime("02.07.2026"), AbsenceReason.Other, "testComment");
            var result = testNote.GetDetails();
            Assert.Equal("1/1 (02.07.2026) => Other [testComment]", result);
        }

        [Fact]
        public void Test4()
        {
            var testNote = new AbsenceNote(0, 1, Convert.ToDateTime("02.02.2026"), AbsenceReason.MedicalAppointment);
            var result = testNote.Validate();
            Assert.False(result);
        }


        [Fact]
        public void Test5()
        {
            var testNote = new AbsenceNote(0, 1, Convert.ToDateTime("02.02.2026"), AbsenceReason.Excused);
            var result = testNote.IsExcused();
            Assert.True(result);
        }

        // ================================
        // MODULES : Student
        // ================================

        [Fact]
        public void Test6()
        {
            Student student = new Student("test", "test", 1, false,Status.Absent);
            var result = student.ToString();
            Assert.Equal("test test - Present (Absent)", result);
        }

        [Fact]
        public void Test7()
        {
            Student student = new Student("test", "test", 1, false, Status.Absent);
            var result = student.GetFullName();
            Assert.Equal("test test", result);
        }

        [Fact]
        public void Test8()
        {
            Student student = new Student(1, "test", "test", 1, false, Status.Absent);
            var result = student.GetDetails();
            Assert.Equal("Students_ID: 1\r\nFirstname: test\r\nLastname: test\r\nClass_ID: 1\r\nAbsence: False\r\nStatus: Absent", result);
        }
    }
}