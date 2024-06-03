using AutoMapper;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Queries.GetById
{
    public class GetByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        : IRequestHandler<GetByIdQuery, BlogVm>
    {
        public async Task<BlogVm> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await blogRepository.GetById(request.BlogId);
            return mapper.Map<BlogVm>(blog);
        }
    }
}
