# Dentist Booking System
My own project used as my portfolio. This project is an appointment booking system for dental practices.
This project is being further developed. It is not yet fully functional for commercial use!
 
## Technologies
* [C# ASP.NET CORE 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/core/)
* [CQRS](https://docs.microsoft.com/en-us/azure/architecture/patterns/cqrs#:~:text=CQRS%20stands%20for%20Command%20and,performance%2C%20scalability%2C%20and%20security.)
* [AutoMapper](https://automapper.org/)
* [MediatR](https://github.com/jbogard/MediatR)
* [FluentValidation](https://fluentvalidation.net/)
* [NLog](https://nlog-project.org/)

## Getting Started

1. Download Project.
2. Download and install **Microsoft SQL Server Management Studio**.
3. Add a new database in **Microsoft SQL Server Management Studio**.
4. Add new connection to string to your database in DentistBookingSystem.DataAccess = > **AppointmentStorageContextFactory.cs**.
```csharp
var optionsBuilder = new DbContextOptionsBuilder<AppointmentStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=AppointmentStorage;Integrated Security=True");
```
5. Add another connection string to your database in DentistBookingSystem => **appsettings.json**.
```
"ConnectionStrings": {
    "AppointmentsDatabaseConnection": "Data Source=.\\SQLEXPRESS;Initial Catalog=AppointmentStorage;Integrated Security=True"
  }
```
6. Update database with migrations using **Package Manager Console**, change Default project to DentistBookingSystem.DataAccess and use
`update-database`.
7. Setup Multiple startup projects in **Visual Studio** for `BlazorApp` and `DentistBookingSystem`.
8. Run a project!
9. Register new user using Postman, Swagger or Blazor UI.
  * Using Postman or Swager use HTTP POST request method to `Users` `http://localhost/Users` using JSON.
```
{
  "name": "Your Name",
  "surname": "Your Surname",
  "email": "Your@email.address",
  "password": "password",
  "birthDate": "2021-08-07T20:46:55.268Z",
  "phoneNumber": "123456789",
  "gender": "male"
}
```
* All users who register with the system. They are register as normal users(patients). If you would like to have access to the Administrator/Recepcjonist panel, then you have to change the role in the database manually.
  * Change the role in database using **Microsoft SQL Server Management Studio** table **dbo.Users** Column `Role`.
```
 0 - Normal user
 1 - Recepcjonist
 2 - Administrator
```


## What the software can do so far
- Access from administrator and receptionist accounts to the list of all registered users.
- Searching for users by first and last name.
- New user registration.
- Adding new "free to take" appointments in the role of receptionist.
- Adding new appointments in the role of receptionist with user allocation.
- Remove/edit/cancel appointments as a receptionist.


### What needs to be fixed/added 
- Editing registered user data (password, names, address, phone number etc).
- Confirmation of e-mail address.
- Upfront payment for the appointment.
- Adding waiting list for users who need an appointment ASAP.
- Several bugs to be fixed.
- Changing roles for users in Administrator panel.

