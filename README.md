# DotNetAppSuite

**DotNetAppSuite** is a collection of .NET projects that demonstrate how different applications interact with each other using different technologies within the .NET ecosystem. This repository includes console applications, a Web API, and a cross-platform MAUI application, all working together with a SQL Server database.

## Table of Contents

- [DotNetAppSuite](#dotnetappsuite)
  - [Table of Contents](#table-of-contents)
  - [Included Projects](#included-projects)
    - [1. `DataManager` (C# Console Application - CRUD with SQL Server)](#1-datamanager-c-console-application---crud-with-sql-server)
    - [2. `DataAPI` (Web API)](#2-dataapi-web-api)
    - [3. `ClientAPI` (C# console application that uses the Web API)](#3-clientapi-c-console-application-that-uses-the-web-api)
    - [4. `MauiAppConnect` (MAUI Application)](#4-mauiappconnect-maui-application)
  - [Requirements](#requirements)
  - [Installation](#installation)
    - [Step 1: Clone the repository](#step-1-clone-the-repository)
  - [Authors](#authors)
  - [Contributions](#contributions)
  - [Code of Conduct](#code-of-conduct)
  - [Security](#security)
  - [Support](#support)
  - [License](#license)
  - [Versions](#versions)

## Included Projects

This repository contains the following projects:

### 1. `DataManager` (C# Console Application - CRUD with SQL Server)

A console application that implements CRUD (Create, Read, Update, Delete) operations on a SQL Server database.

### 2. `DataAPI` (Web API)

A Web API that interacts with the SQL Server database, providing an interface for performing CRUD operations via HTTP requests.

### 3. `ClientAPI` (C# console application that uses the Web API)

A second console application that consumes the Web API to interact with data, rather than directly accessing the database.

### 4. `MauiAppConnect` (MAUI Application)

A MAUI application that also connects to the Web API to interact with the SQL Server database, demonstrating how to build cross-platform applications with .NET.

## Requirements

To run this project, you'll need the following:

- **.NET 6.0 or higher** (including MAUI for cross-platform applications)
- **SQL Server** (or a SQL Server-compatible database)
- **Visual Studio** or **Visual Studio Code** with .NET support
- Tools for working with APIs such as **Postman** or **cURL** (if you want to test the API directly)

## Installation

### Step 1: Clone the repository

```bash
git clone https://github.com/Rigui73/dotnet-app-suite.git
```

## Authors

**[Adrià Rigall](https://www.github.com/Rigui73)** - Lead Author

## Contributions

Please read [`CONTRIBUTING.md`](/.github/CONTRIBUTING.md) for details on our process for submitting pull requests.

## Code of Conduct

Please read [`CODE_OF_CONDUCT.md`](/.github/CODE_OF_CONDUCT.md) for details on our code of conduct.

## Security

Read [`SECURITY.md`](/.github/SECURITY.md) to learn about our security policies and how to report vulnerabilities.

## Support

If you like this project and want to support it, you can make a donation:

[![Donate with PayPal](https://img.shields.io/badge/Donate-PayPal-blue.svg)](https://paypal.me/Rigui73)

You can also see other funding options in our [`FUNDING.yml`](./.github/FUNDING.yml) file.

## License

This project is licensed under the MIT License, See the [`LICENSE`](./LICENSE) file for more information.

## Versions

View all changes made to the project in the [`CHANGELOG.md`](/CHANGELOG.md) file.
