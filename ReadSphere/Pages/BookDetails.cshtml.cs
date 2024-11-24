using Microsoft.AspNetCore.Mvc.RazorPages;

public class BookDetailsModel : PageModel
{
    public Book Book { get; set; }

    public void OnGet(int id)
    {
        // Mock data (Replace with data from the database) in future :(
        var books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "The Alchemist",
                Author = "Ayman",
                Description = "A philosophical story about following your dreams.",
                Reviews = new List<string> { "Inspiring!", "A must-read for dreamers." },
                Quotes = new List<string> { "And, when you want something, all the universe conspires in helping you to achieve it." }
            },
            new Book
            {
                Id = 2,
                Title = "1984",
                Author = "dsoqi",
                Description = "A dystopian novel about totalitarianism and surveillance.",
                Reviews = new List<string> { "Chilling and thought-provoking.", "Timeless classic." },
                Quotes = new List<string> { "War is peace. Freedom is slavery. Ignorance is strength." }
            }
        };

        // Find the book by ID
        Book = books.Find(b => b.Id == id);
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public List<string> Reviews { get; set; }
        public List<string> Quotes { get; set; }
    }
}
