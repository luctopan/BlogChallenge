using Dapper.Contrib.Extensions;

namespace BlogChallenge.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category()
            => Posts = new List<Post>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        [Write(false)] // não escreve no Post no momento do INSERT
        public List<Post> Posts { get; set; }
    }
}