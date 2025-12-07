# Clinic Management Application

![Clinic Management Preview](ClinicManagement_proj/Static/HealthCareClinicPreview.gif)

A multi-tier desktop application for managing clinic operations, developed for the Multi-tier Application Development course at College LaSalle.

![Clinic Management Preview](ClinicManagement_proj/Static/HealthCareClinicPreview.gif)

A multi-tier desktop application for managing clinic operations, developed for the Multi-tier Application Development course at College LaSalle.

## Features

- **User Authentication**: Role-based login for doctors, receptionists, and administrators.
- **Appointment Management**: Book, cancel, and view appointments with scheduling support.
- **Patient Records**: Comprehensive patient data management and clinical summaries.
- **Doctor Scheduling**: Manage doctor availability, workloads, and schedules.
- **Reports and Analytics**: Generate reports on appointments, patient records, and doctor statistics.
- **Notifications**: In-app notifications for updates and alerts.

## Technologies

- **Frontend**: Windows Forms (C#) with role-specific dashboards.
- **Backend**: C# Business Logic Layer (BLL) with services for appointments, patients, doctors, and users.
- **Data Access**: Entity Framework with SQL Server database, including stored procedures and views.
- **Database**: SQL Server with Entity Framework models and migrations.

## Architecture

The application follows a multi-tier architecture:
- **Presentation Layer (UI)**: Windows Forms for user interaction, including dashboards and controllers for panel management.
- **Business Logic Layer (BLL)**: Services and utilities handling application logic, data validation, and notifications.
- **Data Access Layer (DAL)**: Entity Framework context for database operations, with models, stored procedures, and views.

## Installation

### Prerequisites
- .NET Framework 4.8 or later

### From Release (Recommended for End Users)
Download the latest release from [here](https://github.com/shayandelbari/clinic-management/releases/latest). Run the installer; the setup will handle the rest, including database configuration.

To uninstall, simply go to Settings > Apps and uninstall the application.

### From Source (For Developers)
1. Clone the repository and open `ClinicManagement_sol.sln` in Visual Studio.
2. Restore NuGet packages (Entity Framework 6.5.1).
3. Run the database script in `DAL/HealthCareClinicDB_T2_Script.sql` to set up the database.
4. Build and run the application.

## Usage

- Launch the application and log in with appropriate credentials.
- Navigate through dashboards based on user role.
- Manage appointments, patients, and schedules as needed.
- View reports and notifications for operational insights.

