using Application.Common.Mappings;
using Domain.Entity;

namespace Application.Blogs
{
    public class BlogVm : IMapFrom<Blog>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public DateTime Created_Date { get; set; }
    }
}
