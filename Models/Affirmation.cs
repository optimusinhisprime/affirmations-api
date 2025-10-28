namespace AffirmationsAPI.Models;

    public class Affirmation
    {
        public int Id { get; set; }
    public string Title { get; set; } = "";

        public string Body { get; set; } = "";
        public string? Author { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
