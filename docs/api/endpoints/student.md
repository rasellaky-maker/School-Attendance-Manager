### GET /api/student/

**Response 200:**
```json
[
    {
        "id": 1,
        "firstName": "Anna",
        "lastName": "Müller",
        "schoolClassId": 3,
        "absenceStatus": "Present",
        "fullName": "Anna Müller"
    },
    {
        "id": 2,
        "firstName": "Marko",
        "lastName": "Ivanov",
        "schoolClassId": 3,
        "absenceStatus": "Absent",
        "fullName": "Marko Ivanov"
    },
    ...
]
```

**Response 500:**
```json
{
  "status": 500,
  "error": "Internal Server Error",
  "message": "Internal server error. Our team has already been notified of the issue.",
  "timestamp": "2026-06-30T13:47:00"
}
```


### GET /api/student/{lastname}

**Path parameters:**
```text
lastname - the student's last name used for the search
type: string
Required: Yes
example: /api/student/Müller
```

**Response 200:**
```json
    {
        "id": 1,
        "firstName": "Anna",
        "lastName": "Müller",
        "schoolClassId": 3,
        "absenceStatus": "Present",
        "fullName": "Anna Müller"
    }
```

**Response 404:**
```json
{
  "status": 404,
  "error": "Not Found",
  "message": "Student with lastName 'Müller' was not found.",
  "timestamp": "2026-06-30T13:47:00"
}
```

**Response 500:**
```json
{
  "status": 500,
  "error": "Internal Server Error",
  "message": "Internal server error. Our team has already been notified of the issue.",
  "timestamp": "2026-06-30T13:47:00"
}
```


### GET /api/student/{id}

**Path parameters:**
```text
id - the student's id used for the search
type: integer
Required: Yes
example: /api/student/1
```


**Response 200:**
```json
    {
        "id": 1,
        "firstName": "Anna",
        "lastName": "Müller",
        "schoolClassId": 3,
        "absenceStatus": "Present",
        "fullName": "Anna Müller"
    }
```

**Response 404:**
```json
{
  "status": 404,
  "error": "Not Found",
  "message": "Student with id '1' was not found.",
  "timestamp": "2026-06-30T13:47:00"
}
```

**Response 500:**
```json
{
  "status": 500,
  "error": "Internal Server Error",
  "message": "Internal server error. Our team has already been notified of the issue.",
  "timestamp": "2026-06-30T13:47:00"
}
```


### GET /api/student/absence

**Response 200:**

```json
[
    {
        "id": 1,
        "firstName": "Anna",
        "lastName": "Müller",
        "schoolClassId": 3,
        "absenceStatus": "Present",
        "fullName": "Anna Müller"
    },
    {
        "id": 2,
        "firstName": "Marko",
        "lastName": "Ivanov",
        "schoolClassId": 3,
        "absenceStatus": "Absent",
        "fullName": "Marko Ivanov"
    },
    ...
]
```

**Response 500:**
```json
{
  "status": 500,
  "error": "Internal Server Error",
  "message": "Internal server error. Our team has already been notified of the issue.",
  "timestamp": "2026-06-30T13:47:00"
}
```