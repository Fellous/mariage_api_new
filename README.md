# README for API Project: Mariage API

The Mariage API serves as the backend for the Mariage Management WPF application. It provides RESTful services for managing wedding-related data including guest lists, event details, and more.

## Features

- RESTful endpoints for CRUD operations on wedding data
- Secure, scalable, and maintainable codebase
- Seamless integration with the WPF client application
- Data validation to ensure integrity and quality of information

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- SQL Server (or other compatible databases)
- An IDE like Visual Studio or VS Code with C# support

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/Fellous/mariage_api_new.git
   ```
2. Navigate to the `mariage_api_new` directory and open the solution file.
3. Modify the `appsettings.json` to connect to your database.
4. Run database migrations if necessary to set up your database schema.
5. Start the API through your IDE or use the command:
   ```
   dotnet run
   ```

## Usage

The API provides the following endpoints:

- `/api/invites`: Manage wedding invites
- `/api/mariages`: Manage wedding details

Use these endpoints with the appropriate HTTP methods (`GET`, `POST`, `PUT`, `DELETE`) to interact with the API.

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

Please check the [CONTRIBUTING.md](https://github.com/Fellous/mariage_api_new/CONTRIBUTING.md) file for detailed contribution guidelines.

## License

Distributed under the MIT License. See [LICENSE](https://github.com/Fellous/mariage_api_new/LICENSE) for more information.

## Contact

David Fellous - fellousdavid95200@gmail.com

Project Link: [https://github.com/Fellous/mariage_api_new.git](https://github.com/Fellous/mariage_api_new.git)

---

*Note: Please ensure to create the CONTRIBUTING.md and LICENSE files if they do not exist and link them appropriately.*
