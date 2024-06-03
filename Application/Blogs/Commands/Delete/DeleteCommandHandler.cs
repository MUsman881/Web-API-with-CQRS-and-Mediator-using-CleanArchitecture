using Domain.Repository;
using MediatR;

namespace Application.Blogs.Commands.Delete
{
    public class DeleteCommandHandler(IBlogRepository blogRepository)
        : IRequestHandler<DeleteCommand, int>
    {
        public async Task<int> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            return await blogRepository.DeleteBlog(request.BlogId);
        }
    }
}
