using AutoMapper;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Queries.GetAll
{
    public class GetBlogsQueryHandler(IBlogRepository blogRepository, IMapper mapper) 
        : IRequestHandler<GetBlogsQuery, List<BlogVm>>
    {
        public async Task<List<BlogVm>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            var blogs = await blogRepository.GetAllBlogs();
            var blogsList = mapper.Map<List<BlogVm>>(blogs);

            return blogsList;
        }
    }
}
