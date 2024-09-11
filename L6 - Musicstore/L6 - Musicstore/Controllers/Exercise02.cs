using L6___Musicstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace L6___Musicstore.Controllers
{
    public class Exercise02 : Controller
    {
        public IActionResult Index()
        {
            Book book1 = new("The Catcher in the Rye", 199.99, "J.D. Salinger", "Little, Brown and Company", 1951, "978-0316769488");
            Book book2 = new("To Kill a Mockingbird", 149.99, "Harper Lee", "J.B. Lippincott & Co.", 1960, "978-0061120084");
            Book book3 = new("1984", 129.99, "George Orwell", "Secker & Warburg", 1949, "978-0451524935");
            Book book4 = new("Pride and Prejudice", 99.99, "Jane Austen", "T. Egerton, Whitehall", 1813, "978-1503290563");
            Book book5 = new("Moby-Dick", 159.99, "Herman Melville", "Harper & Brothers", 1851, "978-1503280786");


            List<string> tracks1 = new List<string> { "Wanna Be Startin' Somethin'", "Thriller", "Beat It", "Billie Jean", "Human Nature" };
            List<string> tracks2 = new List<string> { "Hells Bells", "Shoot to Thrill", "Back in Black", "You Shook Me All Night Long", "Rock and Roll Ain't Noise Pollution" };
            List<string> tracks3 = new List<string> { "Speak to Me", "Breathe", "Time", "Money", "Us and Them" };
            List<string> tracks4 = new List<string> { "Second Hand News", "Dreams", "Go Your Own Way", "The Chain", "You Make Loving Fun" };

            MusicCD cd1 = new MusicCD("Thriller", 129.99, "Michael Jackson", "Epic Records", 1982, tracks1);
            MusicCD cd2 = new MusicCD("Back in Black", 119.99, "AC/DC", "Atlantic Records", 1980, tracks2);
            MusicCD cd3 = new MusicCD("The Dark Side of the Moon", 139.99, "Pink Floyd", "Harvest Records", 1973, tracks3);
            MusicCD cd4 = new MusicCD("Rumours", 109.99, "Fleetwood Mac", "Warner Bros. Records", 1977, tracks4);

            ViewBag.Books = new List<Book>
            {
                book1, book2, book3, book4, book5
            };
            ViewBag.CDs = new List<MusicCD>
            {
                cd1, cd2, cd3, cd4 
            };

            return View();
        }
    }
}
