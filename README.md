# MinyanApp-API

## Overview

MinyanApp-API is the backend service for the MinyanApp, providing API endpoints for managing users, locations, and minyan notifications. This repository contains the core logic, data management, and service layers necessary for the application's functionality.

## Features

- Location tracking interfaced with Google Maps API
- Implemented Clean Architecture
- Entity Framework
- Swagger for API testing
- Singleton pattern
- Tech stack: C#, SQL Server
- Planned and designed using Figma

## Project Structure

- `MinyanApp.API/`: API controllers and startup configuration
- `MinyanApp.Core/`: Core business logic and domain models
- `MinyanApp.Data/`: Data access layer and database context
- `MinyanApp.Service/`: Services for handling business logic

## Endpoints

### /minyan
- **GET**: Returns a list of minyans
- **POST**: Expects a JSON body with Minyan object
- **POST /{synagogueId}**: Expects a JSON body with Minyan object

### /synagogue
- **GET**: Returns a list of synagogues
- **GET /{id}**: Returns the synagogue with specified ID
- **GET /{lat},{lng}**: Returns the synagogue with specified latitude and longitude
- **POST**: Expects a JSON body with Synagogue object

### /user
- **GET**: Returns a list of users
- to be converted to POST with JWT → **GET /{nickname},{password}**: Returns the user with specified nickname and password 
- **POST**: Expects a JSON body with User object

## Entities

### Location
```csharp
public class Location
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double? Accuracy { get; set; }
    public double? Distance { get; set; }
    public DateTime? DateTime { get; set; }
}
```

### Minyan
```csharp
public class Minyan
{
    public int Id { get; set; }
    public ePrayer Prayer { get; set; }
    public Synagogue? Synagogue { get; set; }
    public Location? Location { get; set; }
    public eNusach? Nusach { get; set; }
    public bool IsFixed { get; set; }
    public DateTime? DateTime { get; set; }
}
```

### Synagogue
```csharp
public class Synagogue
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Location Location { get; set; }
    public eNusach Nusach { get; set; }
    public bool IsVerified { get; set; } = false;
    public bool IsFavorite { get; set; } = false;
    public List<Minyan>? Minyans { get; set; }
    public List<User>? Users { get; set; }
    
    public Synagogue()
    {
        Minyans = new List<Minyan>();
        Users = new List<User>();   
    }
}
```

### User
```csharp
public class User
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Nickname { get; set; }
    public string? Phone { get; set; }
    public string Email { get; set; }
    public string? Avatar { get; set; }
    public string Password { get; set; }
    public bool IsGabai { get; set; } = false;
    public Synagogue? Synagogue { get; set; }
}
```

## Client Side
The frontend repository for this project can be found [here](https://github.com/ChSagron/MinyanApp-React).