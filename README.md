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
|   |   ├── modules-uml
|   ├── api/
|   └── DECISIONS.md
├─── src/
|   ├── SAM.API
|   |   ├── Controllers
|   |   |   ├── 
|   |   |   └── User
|   |   ├── appsettings.json
|   |   ├── log.txt
|   |   └── Programm.cs
|   ├── SAM.Infrastructure
|   └── SAM.WinForms
├─── database/
|   ├── schema.sql
|   └── seed.sql
├── README.md
├── TASKS.md
└── .gitignore
```

##  License

MIT