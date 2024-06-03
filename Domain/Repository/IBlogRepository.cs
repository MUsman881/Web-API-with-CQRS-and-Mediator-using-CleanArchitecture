using Domain.Entity;

namespace Domain.Repository
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogs();
        Task<Blog> GetById(int id);
        Task<int> CreateBlog(Blog blog);
        Task<int> UpdateBlog(int Id, Blog blog);
        Task<int> DeleteBlog(int Id);
    }
}
