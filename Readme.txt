Clean Architecture Project Setup.

1. Domain Layer (Can be a project name depending on naming convention):
=> Domain project includes Entities, Core business rules, Factory Interfaces, Enumerations, Value Objects, Custom Exceptions and so on.
=> Domain layer is not allowed to reference into any outer layer.+

2. Application Layer:
=> Application layer includes Use cases, use services and mediatR handlers.
=> Application layer is allowed to reference Domain layer.
=> In application layer we moslty install libraries like MediatR, AutoMapper, FluentValidation, etc.

3. Infrastructure Layer:
=> Infrastructure layer includes Repositories, Database Context, External Services, Logging, Caching, etc.

4. Presentation Layer:
=> Presentation layer includes Web API, MVC, Blazor, Razor Pages, etc.