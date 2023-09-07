namespace Гостевая_книга_Guest_Book.Models
{
    public class User
    {
        public int Id { get; set; }

        ICollection<Message> Messages { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public string? Salt { get; set; }
    }
}