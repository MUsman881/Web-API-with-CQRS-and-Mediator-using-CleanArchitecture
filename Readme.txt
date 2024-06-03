<h1>Simple CRUD Web API in ASP.NET Core 8</h1>

<p>This repository contains a simple yet robust CRUD (Create, Read, Update, Delete) web API project built with ASP.NET Core 8, utilizing the CQRS (Command Query Responsibility Segregation) and MediatR patterns. This project serves as a demonstration of best practices in modern web API development, providing a clean architecture and separation of concerns.</p>

<h2>Features</h2>
<ul>
    <li><strong>ASP.NET Core 8</strong>: Leverages the latest features and performance improvements of ASP.NET Core 8.</li>
    <li><strong>CQRS Pattern</strong>: Implements Command Query Responsibility Segregation to separate read and write operations, enhancing scalability and maintainability.</li>
    <li><strong>MediatR</strong>: Uses MediatR to handle application requests and responses, promoting a decoupled and flexible architecture.</li>
    <li><strong>Entity Framework Core</strong>: Integrates with EF Core for data access, enabling efficient database operations.</li>
    <li><strong>Dependency Injection</strong>: Built-in dependency injection for managing service lifetimes and dependencies.</li>
    <li><strong>Validation</strong>: Implements FluentValidation for robust request validation.</li>
    <li><strong>Exception Handling</strong>: Global exception handling middleware to manage errors consistently.</li>
    <li><strong>Swagger</strong>: Integrated Swagger for API documentation and testing.</li>
</ul>

<h2>Project Structure</h2>
<p>The project is structured to promote clean architecture principles and maintainability:</p>
<ul>
    <li><strong>Domain</strong>: Contains core business logic and entities.</li>
    <li><strong>Application</strong>: Houses CQRS commands, queries, and handlers.</li>
    <li><strong>Infrastructure</strong>: Includes data access implementations using Entity Framework Core.</li>
    <li><strong>API</strong>: Contains controllers, middleware, and configuration files.</li>
</ul>

<h2>Getting Started</h2>

<h3>Prerequisites</h3>
<ul>
    <li><a href="https://dotnet.microsoft.com/download/dotnet/8.0">.NET SDK 8</a></li>
    <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">SQL Server</a> or any other supported database</li>
</ul>

<h3>Usage</h3>
<p>Access the API documentation and test endpoints via Swagger UI at <code>https://localhost:5001/swagger</code>.</p>

<h2>Contributing</h2>
<p>Contributions are welcome! Please fork this repository, create a new branch, and submit a pull request with your changes. Ensure that your code adheres to the established code style and includes relevant tests.</p>
