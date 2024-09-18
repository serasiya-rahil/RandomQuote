using Microsoft.AspNetCore.Mvc;
using RandomQuote.Services;

namespace RandomQuote.Controllers
{
    public class Home : Controller
    {
        private readonly ServiceQuoteInterface _quoteService;
        private static int _quotecount = 0;

        public Home(ServiceQuoteInterface quoteService)
        {
            _quoteService = quoteService;
        }

        public IActionResult Index()
        {
            var quote = _quoteService.GetRandomQuote();
            return View(quote);
        }

        public IActionResult OtherPage()
        {
            _quotecount++;

            ViewBag.QuoteCount = _quotecount;
            var quote = _quoteService.GetRandomQuote();
            return View(quote);
        }
    }
}
