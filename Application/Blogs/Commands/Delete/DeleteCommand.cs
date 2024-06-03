using MediatR;

namespace Application.Blogs.Commands.Delete
{
    public record DeleteCommand(int BlogId) : IRequest<int>;
}
