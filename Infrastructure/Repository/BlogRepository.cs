using Domain.Entity;
using Domain.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public sealed class BlogRepository(ApplicationDbContext context) : IBlogRepository
    {
        public async Task<int> CreateBlog(Blog blog)
        {
            await context.Blogs.AddAsync(blog);
            await context.SaveChangesAsync();
            return blog.Id;
        }

        public async Task<int> DeleteBlog(int Id)
        {
            return await context.Blogs
                .Where(x => x.Id == Id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogs()
        {
            return await context.Blogs.ToListAsync();
        }

        public async Task<Blog> GetById(int id)
        {
            return await context.Blogs.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateBlog(int Id, Blog blog)
        {
            return await context.Blogs
                .Where(x => x.Id == Id)
                .ExecuteUpdateAsync(u => u
                  .SetProperty(m => m.Name, blog.Name)
                  .SetProperty(m => m.Author, blog.Author)
                  .SetProperty(m => m.Description, blog.Description)
                  .SetProperty(m => m.Modified_Date, blog.Modified_Date)
                );
        }
    }
}
