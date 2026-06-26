# FinalCourseRegistration

A simple course registration management system built with ASP.NET Core Razor Pages. Allows browsing and managing student and course records, with a read-only instructor directory.

## Features

- **Students** — full CRUD (Create, Read, Update, Delete)
- **Courses** — full CRUD (Create, Read, Update, Delete)
- **Instructors** — read-only directory
- Data persisted to a local SQLite database
- Clean, warm academic-themed UI built on Bootstrap

## Tech Stack

- **Framework:** ASP.NET Core 9 (Razor Pages)
- **Database:** SQLite via Entity Framework Core
- **Frontend:** Bootstrap 5, custom CSS theme
- **Language:** C#

## Project Structure

FinalCourseRegistration/

├── Data/

│ └── AppDbContext.cs # EF Core database context

├── Models/

│ ├── Student.cs

│ ├── Course.cs

│ └── Instructor.cs

├── Pages/

│ ├── Students/ # Index, Create, Edit, Delete

│ ├── Courses/ # Index, Create, Edit, Delete

│ ├── Instructors/ # Index (read-only)

│ ├── Shared/ # \_Layout.cshtml

│ ├── Index.cshtml # Home page

│ └── Privacy.cshtml

├── wwwroot/

│ ├── css/

│ │ ├── site.css # Academic theme (nav, headings, tables)

│ │ └── styles.css # Hero/overlay styling

│ └── lib/ # Bootstrap, jQuery

├── app.db # SQLite database file

└── Program.cs

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- A code editor (VS Code or Visual Studio)

### Setup

1. Clone or download the project
2. Restore dependencies:

```bash
   dotnet restore
```

3. Apply database migrations (creates and seeds `app.db`):

```bash
   dotnet ef database update
```

4. Run the app:

```bash
   dotnet run
```

5. Open the URL shown in the terminal (e.g. `http://localhost:5119`) in your browser

### Database Notes

The SQLite database (`app.db`) is created automatically the first time you run `dotnet ef database update`. It comes pre-seeded with sample students and courses so the app has data to display right away.

If you ever need to reset the database, delete `app.db` and re-run:

```bash
dotnet ef database update
```

## Usage

- **Home** — landing page
- **Students** — view all students; add, edit, or delete records
- **Courses** — view all courses; add, edit, or delete records
- **Instructors** — view the instructor directory (read-only)

## Possible Future Enhancements

- Full CRUD for Instructors
- Enrollment relationship linking Students to Courses (many-to-many)
- User authentication and role-based access (e.g. only instructors can edit records)
- Search and filtering on list pages
- Form validation messages and improved error handling

## Known Limitations

- No authentication — anyone with access to the app can add, edit, or delete records
- Instructors list is currently view-only with no management interface
