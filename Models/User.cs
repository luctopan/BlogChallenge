using Dapper.Contrib.Extensions;

namespace BlogChallenge.Models
{
    [Table("[User]")]
    public class User
    {
        public User()
            => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        [Write(false)] // não escreve no Roles no momento do INSERT
        public List<Role> Roles { get; set; }
    }
}