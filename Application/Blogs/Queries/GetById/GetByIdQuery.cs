using MediatR;

namespace Application.Blogs.Queries.GetById
{
    public record GetByIdQuery(int BlogId) : IRequest<BlogVm>;
}
