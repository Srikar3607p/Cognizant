# StudentAPI

## Project Overview

StudentAPI is a simple ASP.NET Core 8 Web API project.

This project is made for a beginner student to understand basic CRUD operations using a simple list instead of a real database.

## Folder Structure

```text
StudentAPI
|
|-- Controllers
|   |-- StudentsController.cs
|
|-- Models
|   |-- Student.cs
|
|-- Data
|   |-- AppDbContext.cs
|
|-- DTOs
|   |-- StudentRequest.cs
|   |-- StudentResponse.cs
|
|-- Services
|   |-- StudentService.cs
|
|-- Program.cs
|-- appsettings.json
|-- StudentAPI.csproj
|-- README.md
```

## CRUD Operations

| Method | URL | Description |
| --- | --- | --- |
| GET | `/students` | Get all students |
| GET | `/students/{id}` | Get one student by id |
| POST | `/students` | Add a new student |
| PUT | `/students/{id}` | Update a student |
| DELETE | `/students/{id}` | Delete a student |

## Technologies Used

- .NET 8
- ASP.NET Core Web API
- C#
- Simple `List<Student>` for data storage

## How to Run

1. Open the project folder.
2. Run this command:

```bash
dotnet run
```

3. Test the student API endpoints using a browser, Postman, or any API testing tool.
