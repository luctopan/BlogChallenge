using Dapper.Contrib.Extensions;

namespace BlogChallenge.Models
{
    [Table("[Category]")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Post { get; set; }
    }
}