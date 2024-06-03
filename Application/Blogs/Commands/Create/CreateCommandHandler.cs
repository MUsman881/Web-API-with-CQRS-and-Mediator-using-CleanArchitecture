using Domain.Entity;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Commands.Create
{
    public class CreateCommandHandler(IBlogRepository blogRepository)
        : IRequestHandler<CreateCommand, int>
    {
        public async Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var data = new Blog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author,
                Created_Date = request.Created_Date
            };

            return await blogRepository.CreateBlog(data);
        }
    }
}
