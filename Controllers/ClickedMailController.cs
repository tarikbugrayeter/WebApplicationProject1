using Microsoft.AspNetCore.Mvc;
using WebApplicationProject1.Models;
namespace WebApplicationProject1.Controllers
{
    public class ClickedController : Controller
    {
        private readonly WebDatabaseContext _context;

        public ClickedController(WebDatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult TrackClick([FromBody] ClickedMail clickedMail)
        {
            // Burada ClickedMail verisini alarak ClickedMail tablosuna ekleme işlemlerini gerçekleştirin
            // clickedMail.EmailId kullanılabilir

            _context.ClickedMails.Add(clickedMail);
            _context.SaveChanges();

            return Ok();
        }
    }
}
