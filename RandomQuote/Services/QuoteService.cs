using RandomQuote.Models;
using RandomQuote.Services;

namespace YourNamespace.Services
{
    public class QuoteService : ServiceQuoteInterface
    {
        private readonly List<Quote> _quotes;
        private readonly Random _random;

        public QuoteService()
        {
            _random = new Random();
            _quotes = new List<Quote>
            {
                new Quote { Text = "Success usually comes to those who are too busy to be looking for it.", Author = "Henry David Thoreau" },
                new Quote { Text = "Don’t watch the clock; do what it does. Keep going.", Author = "Sam Levenson" },
                new Quote { Text = "The secret of getting ahead is getting started.", Author = "Mark Twain" },
                new Quote { Text = "The best time to plant a tree was 20 years ago. The second best time is now.", Author = "Chinese Proverb" },
                new Quote { Text = "Opportunities don't happen, you create them.", Author = "Chris Grosser" },
                new Quote { Text = "Don’t be afraid to give up the good to go for the great.", Author = "John D. Rockefeller" },
                new Quote { Text = "I find that the harder I work, the more luck I seem to have.", Author = "Thomas Jefferson" },
                new Quote { Text = "If you really want to do something, you'll find a way. If you don't, you'll find an excuse.", Author = "Jim Rohn" },
                new Quote { Text = "You miss 100% of the shots you don’t take.", Author = "Wayne Gretzky" },
                new Quote { Text = "The only place where success comes before work is in the dictionary.", Author = "Vidal Sassoon" }
            };

        }

        public Quote GetRandomQuote()
        {
            int index = _random.Next(10);
            return _quotes[index];
        }

    }
}