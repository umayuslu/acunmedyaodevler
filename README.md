using System;

namespace Car
{
    
    public class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public virtual string Type()
        {
            return "Vites türü belirtilmemiş.";
        }
    }

    
    public class BMW : Car
    {
        public BMW() : base("BMW") { }

        public override string Type()
        {
            return "Düz viteslidir.";
        }
    }

    
    public class Porsche : Car
    {
        public Porsche() : base("Porsche") { }

        public override string Type()
        {
            return "Otomatik viteslidir.";
        }
    }

    
    public class Mercedes : Car
    {
        public Mercedes() : base("Mercedes") { }

        public override string Type()
        {
            return "Otomatik viteslidir.";
        }
    }

    
    public class Togg : Car
    {
        public Togg() : base("Togg") { }

        public override string Type()
        {
            return "Otomatik viteslidir.";
        }
    }

    
    public class Audi : Car
    {
        public Audi() : base("Audi") { }

        public override string Type()
        {
            return "Otomatik viteslidir.";
        }
    }

    
    public class Toyota : Car
    {
        public Toyota() : base("Toyota") { }

        public override string Type()
        {
            return "Otomatik viteslidir.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            BMW bmw = new BMW();
            Console.WriteLine($"{bmw.Name}  {bmw.Type()}");

            Porsche porsche = new Porsche();
            Console.WriteLine($"{porsche.Name}  {porsche.Type()}");

            Mercedes mercedes = new Mercedes();
            Console.WriteLine($"{mercedes.Name}  {mercedes.Type()}");

            Togg togg = new Togg();
            Console.WriteLine($"{togg.Name}  {togg.Type()}");

            Audi audi = new Audi();
            Console.WriteLine($"{audi.Name}  {audi.Type()}");

            Toyota toyota = new Toyota();
            Console.WriteLine($"{toyota.Name}  {toyota.Type()}");
        }
    }
}
