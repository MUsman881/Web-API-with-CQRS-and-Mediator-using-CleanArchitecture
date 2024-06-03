using MediatR;

namespace Application.Blogs.Commands.Create
{
    public record CreateCommand(string Name, string Description, string Author, DateTime Created_Date)
        : IRequest<int>;
}
