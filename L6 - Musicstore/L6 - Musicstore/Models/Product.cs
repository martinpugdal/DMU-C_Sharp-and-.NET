namespace L6___Musicstore.Models
{
    public class Product
    {
        private readonly string title; // field
        public string Title // property
        {
            get { return title; }
        }

        private double price; // field
        public double Price // property
        {
            // 
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public string? ImageUrl // property
        { get; set; }

        public Product()
        {

        }

        public Product(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public Product(string title, double price, string imageUrl)
        {
            this.title = title;
            this.price = price;
            ImageUrl = imageUrl;
        }
    }
}
