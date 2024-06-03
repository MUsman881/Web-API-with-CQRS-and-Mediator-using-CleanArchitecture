namespace Domain.Entity
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
