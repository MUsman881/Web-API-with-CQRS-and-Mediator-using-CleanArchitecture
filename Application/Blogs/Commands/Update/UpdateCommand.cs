using MediatR;

namespace Application.Blogs.Commands.Update
{
    public record UpdateCommand(int Id, string Name, string Description, string Author, DateTime Modified_Date) 
        : IRequest<int>;
}
