# Affirmations API

## Overview

The Affirmations API is a simple ASP.NET Core Web API that allows users to manage affirmations. Users can retrieve, create, and delete affirmations through HTTP requests.

## Project Structure

```
AffirmationsAPI
├── Controllers
│   └── AffirmationsController.cs
├── Models
│   └── Affirmation.cs
├── Services
│   ├── IAffirmationService.cs
│   └── AffirmationService.cs
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
└── README.md
```

## Setup Instructions

1. **Clone the repository:**

   ```
   git clone <repository-url>
   cd AffirmationsAPI
   ```

2. **Restore dependencies:**

   ```
   dotnet restore
   ```

3. **Run the application:**

   ```
   dotnet run
   ```

4. **Access the API:**
   The API will be available at `https://localhost:5001` (or the specified port in your configuration).

## Usage

- **GET /affirmations**: Retrieve a list of affirmations.
- **POST /affirmations**: Create a new affirmation.
- **DELETE /affirmations/{id}**: Delete an affirmation by ID.

## Configuration

- The application settings can be found in `appsettings.json` and `appsettings.Development.json`. Modify these files to configure connection strings and other application-specific settings.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
