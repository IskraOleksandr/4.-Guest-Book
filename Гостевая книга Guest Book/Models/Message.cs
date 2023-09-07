namespace Гостевая_книга_Guest_Book.Models
{
    public class Message
    {
        public int Id { get; set; }

        public virtual User User { get; set; }

        public string MessageText { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
