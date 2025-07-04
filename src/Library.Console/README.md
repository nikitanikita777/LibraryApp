Collecting workspace information# Library App

## Description
Library App is a console-based library management system built with C#. It provides functionality for managing patrons, loans, and books, including searching, renewing memberships, and handling book loans.

## Project Structure
- **AccelerateDevGHCopilot.sln**: Solution file for the project.
- **src/**
  - **Library.ApplicationCore/**
    - `Library.ApplicationCore.csproj`: Core business logic and domain entities.
    - **Entities/**: Contains domain models like `Book` and `Author`.
    - **Enums/**: Defines enums such as `LoanReturnStatus`.
    - **Interfaces/**: Interfaces for services and repositories.
    - **Services/**: Business logic implementations like `LoanService`.
  - **Library.Console/**
    - Library.Console.csproj: Console application project file.
    - `Program.cs`: Entry point for the application.
    - `ConsoleApp.cs`: Manages application states and user interactions.
    - `CommonActions.cs`: Defines common user actions.
    - `ConsoleState.cs`: Enum for application states.
    - `appSettings.json`: Configuration file.
    - **Json/**: Contains JSON data files for persistence.
  - **Library.Infrastructure/**
    - `Library.Infrastructure.csproj`: Data persistence layer.
    - **Data/**: Repository implementations like `JsonLoanRepository`.
- **tests/**
  - **UnitTests/**
    - `UnitTests.csproj`: Unit testing project file.
    - **ApplicationCore/**: Unit tests for core services.
    - `LoanFactory.cs`: Factory for creating loan test data.
    - `PatronFactory.cs`: Factory for creating patron test data.

## Key Classes and Interfaces
- **Core Classes**:
  - `Book`: Represents a book entity.
  - `Author`: Represents an author entity.
- **Services**:
  - `LoanService`: Handles loan-related operations.
  - `PatronService`: Manages patron memberships.
- **Repositories**:
  - `JsonLoanRepository`: JSON-based loan repository.
  - `JsonPatronRepository`: JSON-based patron repository.
- **Console Application**:
  - `ConsoleApp`: Manages application states and user interactions.

## Usage
### Build and Run
1. Clone the repository.
2. Build the solution using Visual Studio or `dotnet build`.
3. Run the console application:
   ```sh
   dotnet run --project src/Library.Console/Library.Console.csproj
   ```

### Features
- Search for patrons by name.
- View patron details and loaned books.
- Renew patron memberships.
- Extend or return book loans.

## License
This project is licensed under the MIT License. See the LICENSE file for details.@workspace describe this project