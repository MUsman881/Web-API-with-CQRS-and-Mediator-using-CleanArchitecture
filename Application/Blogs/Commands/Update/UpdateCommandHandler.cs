using Domain.Entity;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Commands.Update
{
    public class UpdateCommandHandler(IBlogRepository blogRepository)
        : IRequestHandler<UpdateCommand, int>
    {
        public async Task<int> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var update = new Blog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author,
                Modified_Date = DateTime.UtcNow
            };

            return await blogRepository.UpdateBlog(request.Id, update);
        }
    }
}
