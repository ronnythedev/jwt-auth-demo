# JWT Auth Demo

A lightweight, open-source ASP.NET Core application demonstrating JWT (JSON Web Token) authentication implementation.

It’s a companion to [my post](https://ronnydelgado.com/), where I dive deeper.

## Overview

JWT Auth Demo is a simple yet comprehensive example of how to implement JWT-based authentication in ASP.NET Core applications. This project serves as both a reference implementation and a starting point for developers looking to add secure authentication to their web applications.

## Features

- JWT token generation and validation
- User authentication with in-memory database
- Secure password handling
- Protected API endpoints
- Clean, easy-to-understand architecture

## Technology Stack

- ASP.NET Core (.NET 9.0)
- Entity Framework Core with In-Memory Database
- JWT Bearer Authentication

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Any code editor (Visual Studio, VS Code, JetBrains Rider, etc.)

### Installation

1. Clone the repository
   ```bash
   git clone https://github.com/yourusername/jwt-auth-demo.git
   cd jwt-auth-demo
   ```

2. Build the application
   ```bash
   dotnet build
   ```

3. Run the application
   ```bash
   dotnet run
   ```

The application will start on `https://localhost:5001` by default.

## Usage

### Authentication

To authenticate and receive a JWT token:

```http
POST /api/auth/login
Content-Type: application/json

{
  "username": "user@example.com",
  "password": "yourpassword"
}
```

### Using the Token

Include the token in the Authorization header for subsequent requests:

```http
GET /api/protected-resource
Authorization: Bearer your_jwt_token_here
```

## Project Structure

- `Controllers/` - API endpoints
- `Data/` - Database context and models
- `Services/` - Business logic including authentication service

## Configuration

JWT settings can be configured in the `appsettings.json` file:

```json
{
  "Jwt": {
    "Key": "your-secret-key-here",
    "Issuer": "your-issuer",
    "Audience": "your-audience",
    "ExpiryInMinutes": 60
  }
}
```

⚠️ **Note:** For production use, ensure you use a strong secret key stored securely (not in your source code).

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- ASP.NET Core team for the excellent authentication framework
- The open-source community for inspiration and guidance