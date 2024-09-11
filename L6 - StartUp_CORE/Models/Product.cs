﻿public class Product
{
    private readonly string name; // field
    public string Name // property
    {
        get { return name; }
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

    public string ImageUrl // property
    { get; set; }

    private string manufacturer;
    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    // constructor 1
    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // constructor 2
    public Product(string name, double price, string imageUrl, string manufacturer)
    {
        this.name = name;
        this.price = price;
        ImageUrl = imageUrl;
        this.manufacturer = manufacturer;
    }
}