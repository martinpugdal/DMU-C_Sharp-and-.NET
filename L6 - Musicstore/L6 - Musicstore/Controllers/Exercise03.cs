using L6___Musicstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace L6___Musicstore.Controllers
{
    public class Exercise03 : Controller
    {
        public IActionResult Index()
        {

            List<Track> tracks1 = new List<Track>
            {
                new Track("Wanna Be Startin' Somethin'", "Michael Jackson", "6:03"),
                new Track("Thriller", "Rod Temperton", "5:57"),
                new Track("Beat It", "Michael Jackson", "4:18"),
                new Track("Billie Jean", "Michael Jackson", "4:54"),
                new Track("Human Nature", "John Bettis, Steve Porcaro", "4:06")
            };

            List<Track> tracks2 = new List<Track>
            {
                new Track("Hells Bells", "Angus Young, Malcolm Young, Brian Johnson", "5:12"),
                new Track("Shoot to Thrill", "Angus Young, Malcolm Young, Brian Johnson", "5:17"),
                new Track("Back in Black", "Angus Young, Malcolm Young, Brian Johnson", "4:15"),
                new Track("You Shook Me All Night Long", "Angus Young, Malcolm Young, Brian Johnson", "3:30"),
                new Track("Rock and Roll Ain't Noise Pollution", "Angus Young, Malcolm Young, Brian Johnson", "4:15")
            };

            List<Track> tracks3 = new List<Track>
            {
                new Track("Speak to Me", "Mason", "1:30"),
                new Track("Breathe", "Waters, Gilmour, Wright", "2:43"),
                new Track("Time", "Waters, Gilmour, Wright, Mason", "6:53"),
                new Track("Money", "Waters", "6:22"),
                new Track("Us and Them", "Waters, Wright", "7:51")
            };

            List<Track> tracks4 = new List<Track>
            {
                new Track("Second Hand News", "Lindsey Buckingham", "2:56"),
                new Track("Dreams", "Stevie Nicks", "4:17"),
                new Track("Go Your Own Way", "Lindsey Buckingham", "3:43"),
                new Track("The Chain", "Fleetwood Mac", "4:30"),
                new Track("You Make Loving Fun", "Christine McVie", "3:36")
            };

            List<Track> tracks5 = new List<Track>
            {
                new Track("Come Together", "John Lennon, Paul McCartney", "4:20"),
                new Track("Something", "George Harrison", "3:03"),
                new Track("Octopus's Garden", "Ringo Starr", "2:51"),
                new Track("Here Comes the Sun", "George Harrison", "3:06"),
                new Track("The End", "Lennon, McCartney", "2:20")
            };


            MusicCD cd1 = new MusicCD("Thriller", 129.99, "Michael Jackson", "Epic Records", 1982, tracks1);
            MusicCD cd2 = new MusicCD("Back in Black", 119.99, "AC/DC", "Atlantic Records", 1980, tracks2);
            MusicCD cd3 = new MusicCD("The Dark Side of the Moon", 139.99, "Pink Floyd", "Harvest Records", 1973, tracks3);
            MusicCD cd4 = new MusicCD("Rumours", 109.99, "Fleetwood Mac", "Warner Bros. Records", 1977, tracks4);

            ViewBag.CDs = new List<MusicCD>
            {
                cd1, cd2, cd3, cd4
            };

            return View();
        }
    }
}
