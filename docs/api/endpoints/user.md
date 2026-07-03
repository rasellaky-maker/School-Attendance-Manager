### POST /api/auth/login

**Request Body:**
```text
LoginRequest - an object containing login data
Required: Yes
example:
{
  "username": "amüller",
  "password": "qwerty"
}
```

**Response 200:**
```json
{
  "id": 1,
  "firstName": "Anna",
  "lastName": "Müller",
  "username": "amüller",
}
```

**Response 404:**
```json
{
  "status": 404,
  "error": "Not Found",
  "message": "User was not found.",
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


### POST /api/auth/classleader/signin

**Request Body:**
```text
SigninRequest - an object containing data for signin
Required: Yes
example:
{
  firstname: "Anna",
  lastname: "Müller",
  password: "qwerty",
  schoolclass: "1AD",
  invitecode: "XH72KQ"
}
```

**Response 400:**
```json
{
  "status": 400,
  "error": "Bad Request",
  "message": "Invalid request data.",
  "timestamp": "2026-06-30T13:47:00"
}
```

**Response 401:**
```json
{
  "status": 401,
  "error": "Unauthorized",
  "message": "Invalid password.",
  "timestamp": "2026-06-30T13:47:00"
}
```

**Response 403:**
```json
{
  "status": 403,
  "error": "Forbidden",
  "message": "Invalid or expired invite code.",
  "timestamp": "2026-06-30T13:47:00"
}
```

**Response 409:**
```json
{
  "status": 409,
  "error": "Conflict",
  "message": "Class leader already exists.",
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