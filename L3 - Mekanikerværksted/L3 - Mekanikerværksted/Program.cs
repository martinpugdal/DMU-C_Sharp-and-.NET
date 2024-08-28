using L3___Mekanikerværksted;

Time t1, t2;
t1 = new Time("08:30:00");
t2 = t1; // t2 is a copy of t1
t2.Hour = t2.Hour + 2; // This should update t2 without affecting t1
Console.WriteLine(t1.ToString()); // Output: 08:30:00
Console.WriteLine(t2.ToString()); // Output: 10:30:00

namespace L3___Mekanikerværksted
{
    struct Time
    {
        private int _secondsSinceMidnight;
        private const int _maxSeconds = 86400; // 24 hours * 60 minutes * 60 seconds

        public Time(int hours, int minutes, int seconds)
        {
            _secondsSinceMidnight = (hours * 3600 + minutes * 60 + seconds) % _maxSeconds;
        }

        public Time(string time) : this
        (
            Int32.Parse(time.Split(":")[0]),
            Int32.Parse(time.Split(":")[1]),
            Int32.Parse(time.Split(":")[2])
        )
        { }

        public int Hour
        {
            get { return _secondsSinceMidnight / 3600; }
            set { _secondsSinceMidnight = (_secondsSinceMidnight % 3600) + (value * 3600) % _maxSeconds; }
        }

        public int Minute
        {
            get { return (_secondsSinceMidnight % 3600) / 60; }
            set { _secondsSinceMidnight = (_secondsSinceMidnight - Minute * 60) + (value * 60); }
        }

        public int Second
        {
            get { return _secondsSinceMidnight % 60; }
            set { _secondsSinceMidnight = (_secondsSinceMidnight - Second) + value; }
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    }
}

//Medarbejder[] medarbejdere = new Medarbejder[3];
//medarbejdere[0] = new Mekaniker(new CprNr("010101", "1234"), "Hans", "Hovedgaden 1", 1990, 200);
//medarbejdere[1] = new Værkfører(new CprNr("020202", "5678"), "Grethe", "Hovedgaden 2", 1995, 250, 500);
//medarbejdere[2] = new Synsmand(new CprNr("030303", "9876"), "Jens", "Hovedgaden 3", 2000, 5);

//foreach (Medarbejder m in medarbejdere)
//{
//    Console.WriteLine(m);
//    Console.WriteLine("Ugeløn: " + m.BeregnUgeLøn());
//    Console.WriteLine();
//}

//var medarbejderCollection = new MedarbejderListe<CprNr>();
//var morten = new Mekaniker(new CprNr("211271", "7777"), "Morten", "Brabrand", 2017, 195);
//var karina = new Mekaniker(new CprNr("141174", "8888"), "Karina", "Aarhus", 2019, 190);
//medarbejderCollection.AddElement(karina.CprNr, karina);
//medarbejderCollection.AddElement(morten.CprNr, morten);

//// get element from collection
//Console.WriteLine(medarbejderCollection.GetElement(morten.CprNr));
//Console.WriteLine(medarbejderCollection.GetElement(new CprNr("141174", "8888")));
//Console.WriteLine(medarbejderCollection.GetElement(new CprNr("141111", "8888"))); // null

//// get size of collection
//Console.WriteLine(medarbejderCollection.Size());

//var medarbejderCollection = new MedarbejderListe<int>();
//var morten = new Mekaniker(new CprNr("211271", "7777"), "Morten", "Brabrand", 2017, 195);
//var karina = new Mekaniker(new CprNr("141174", "8888"), "Karina", "Aarhus", 2019, 190);
//medarbejderCollection.AddElement(karina.MedarbejderId, karina);
//medarbejderCollection.AddElement(morten.MedarbejderId, morten);

//// get element from collection
//Console.WriteLine(medarbejderCollection.GetElement(morten.MedarbejderId));
//Console.WriteLine(medarbejderCollection.GetElement(2));
//Console.WriteLine(medarbejderCollection.GetElement(3)); // null

//// get size of collection
//Console.WriteLine(medarbejderCollection.Size());

//var medarbejderCollection = new MedarbejderListe<string, IHarAdresse>();
//var firma1 = new Firma("Hoventgaden 1");
//var firma2 = new Firma("Hovedgaden 2");
//var morten = new Mekaniker(new CprNr("211271", "7777"), "Morten", "Hovedgaden 1", 2017, 195);
//var karina = new Mekaniker(new CprNr("141174", "8888"), "Karina", "Hovedgaden 2", 2019, 190);
//medarbejderCollection.AddElement(firma1.Adresse, firma1);
//medarbejderCollection.AddElement(firma2.Adresse, firma2);
//medarbejderCollection.AddElement(karina.Adresse, karina);
//medarbejderCollection.AddElement(morten.Adresse, morten);

//// get element from collection
//Console.WriteLine(medarbejderCollection.GetElement(morten.Adresse));
//Console.WriteLine(medarbejderCollection.GetElement(firma1.Adresse));
//Console.WriteLine(medarbejderCollection.GetElement(karina.Adresse)); // null

//// get size of collection
//Console.WriteLine(medarbejderCollection.Size());

//var medarbejderCollection = new MedarbejderListe<Adresse, IHarAdresse>();
//var firma1 = new Firma(new Adresse("Hoventgaden", "1", "8000", "Skovby"));
//var firma2 = new Firma(new Adresse("Hovedgaden", "2", "8000", "Skovby"));
//var morten = new Mekaniker(new CprNr("211271", "7777"), "Morten", new Adresse("Hovedgaden", "1", "8000", "Skovby"), 2017, 195);
//var karina = new Mekaniker(new CprNr("141174", "8888"), "Karina", new Adresse("Hovedgaden", "2", "8000", "Skovby"), 2019, 190);
//medarbejderCollection.AddElement(firma1.Adresse, firma1);
//medarbejderCollection.AddElement(firma2.Adresse, firma2);
//medarbejderCollection.AddElement(karina.Adresse, karina);
//medarbejderCollection.AddElement(morten.Adresse, morten);

//// get element from collection
//Console.WriteLine(medarbejderCollection.GetElement(morten.Adresse));
//Console.WriteLine(medarbejderCollection.GetElement(firma1.Adresse));
//Console.WriteLine(medarbejderCollection.GetElement(karina.Adresse)); // null

//// get size of collection
//Console.WriteLine(medarbejderCollection.Size());