namespace L6___Musicstore.Models;

public class Book : Product
{

    public string Author { get; set; }
    public string Publisher { get; set; }
    public short Published { get; set; }
    public string ISBN { get; set; }

    public Book() : base()
    {
    }

    public Book(string title, double price, string author, string publisher, short published, string ISBN) : base(title, price)
    {
        Author = author;
        Publisher = publisher;
        Published = published;
        this.ISBN = ISBN;
    }
}
