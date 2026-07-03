# School Attendance Manager

This is a system for tracking student attendance that allows you 
to record who is present and who is absent. The app helps teachers 
and class representatives quickly track attendance and save each 
student's attendance history.

## Features

- Attendance Record
- List of Students
- Visitation History
- Absence statuses 
- Filters and Search

## Installation

```bash
git clone https://github.com/rasellaky-maker/SchoolAttendanceManager.git
cd SchoolAttendanceManager
dotnet restore
```

## Usage

```bash
dotnet run
```

## Project Structure

```text
SchoolAttendanceManager/
├─── docs/
|   ├── uml/
|   |   ├── modules-uml.jpg
|   |   ├── repository-uml.jpg
|   |   ├── servises-uml.jpg
|   |   └── schema-uml.jpg
|   ├── erd/
|   |   └── database_erd.jpg
|   ├── api/
|   |   └── endpoints/
|   |   |   ├── student.md
|   |   |   └── user.md
|   └── DECISIONS.md
├─── src/
|   ├── SAM.API/
|   |   ├── Controllers
|   |   |   ├── 
|   |   |   └── User
|   |   ├── appsettings.json
|   |   ├── log.txt
|   |   └── Programm.cs
|   ├── SAM.Core/
|   |   ├── bin/
|   |   |   ├── Debug/
|   |   |   |   ├── net8.0/
|   |   |   |   |   ├── SAM.Core.deps.json
|   |   |   |   |   ├── SAM.Core.dll
|   |   |   |   |   └── SAM.Core.pdb
|   |   |   ├── Release/
|   |   |   |   ├── net8.0/
|   |   |   |   |   ├── SAM.Core.deps.json
|   |   |   |   |   ├── SAM.Core.dll
|   |   |   |   |   └── SAM.Core.pdb
|   |   ├── Enums/
|   |   |   ├── AbsenceReason.cs
|   |   |   └── Status.cs
|   |   ├── Modules/
|   |   |   ├── AbsenceNote.cs
|   |   |   └── Student.cs
|   |   ├── obj/
|   |   ├── SAM.Core.csproj
|   |   └── SAM.Core.sln
|   └── SAM.WinForms
├─── database/
|   ├── schema.sql
|   └── seed.sql
├── README.md
├── TASKS.md
└── .git
```

## Dependencies

This project uses the following NuGet packages:

- 

##  License

MIT