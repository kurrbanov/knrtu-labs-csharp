using System;

namespace Lab_10
{
class Program
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[4];
            
            p[0] = new Product("Ball");
            p[1] = new groccery("Vegetables", 1234);
            p[2] = new chemi("Poroshok", "Black");
            p[3] = new drinks("Cola", 1000);
            
            for (int i = 0; i < 4; i++)
            {
                p[i].showInf();
                Console.WriteLine();
            }
        }
    }

    class Product
    {
        public string name = "";
        public static int kolvo;
        
        public Product()
        {
            name = "No name";
            kolvo = 10;
        }

        public Product(string Name)
        {
            name = Name;
            kolvo = 10;
        }

        public virtual void showInf()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Quantity: {kolvo}");
        }
        
    }

    class groccery : Product
    {
        private int artikul;
        private string Name;
        
        public groccery()
        {
            artikul = 0;
        }

        public groccery(string name, int artikul) : base(name)
        {
            Name = name;
            this.artikul = artikul;
        }

        public override void showInf()
        {
            base.showInf();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artikul: {artikul}");
        }
        
    }

    class chemi : Product
    {
        private string color;
        private string Name;   
        
        public chemi()
        {
            color = "no color";
        }

        public chemi(string name, string color) : base(name)
        {
            Name = name;
            this.color = color;
        }

        public override void showInf()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {color}");
        }
    }

    class drinks : Product
    {
        private int price;
        private string Name;
        
        public drinks()
        {
            price = 5;
        }

        public drinks(string name, int price) : base(name)
        {
            Name = name;
            this.price = price;
        }

        public override void showInf()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {price}");
        }
    }
}