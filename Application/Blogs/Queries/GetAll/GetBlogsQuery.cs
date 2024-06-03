using MediatR;

namespace Application.Blogs.Queries.GetAll
{
    public record GetBlogsQuery : IRequest<List<BlogVm>>;
}
