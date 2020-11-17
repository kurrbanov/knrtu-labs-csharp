using System;
using System.Collections.Generic;


namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop Lenta = new Shop();
            
            Lenta.addDrinks("Cola");
            Lenta.addChemi("Poroshok");
            Lenta.addGroc("Ovoshi");
            
            Lenta.remove(1);
            Lenta.output();
            Console.WriteLine();
            
            Lenta.changeFiled(0, "Voda");
            Lenta.output();
        }
    }

    class Shop
    {
        List<Product> Elements = new List<Product>();

        public void addGroc(string name)
        {
            Elements.Add(new groccery(name));
        }

        public void addChemi(string name)
        {
            Elements.Add(new chemi(name));
        }

        public void addDrinks(string name)
        {
            Elements.Add(new drinks(name));
        }

        public void changeFiled(int index, string name)
        {
            Elements[index].change(name);
        }

        public void remove(int index)
        {
            Elements.RemoveAt(index);
        }

        public void output()
        {
            foreach (var i in Elements)
            {
                Console.WriteLine($"{i.Name}");
            }
        }
    }
    

    abstract class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Product(string name)
        {
            this.name = name;
        }
        
        public abstract string change(string name);
    }


    class groccery : Product
    {
        public groccery(string name) : base(name){}
        public override string change(string name)
        {
            Name = name;
            return Name;
        }
    }

    class chemi : Product
    {
        public chemi(string name) : base(name) { }

        public override string change(string name)
        {
            Name = name;
            return Name;
        }
    }

    class drinks : Product
    {
        public drinks(string name) : base(name) { }
        public override string change(string name)
        {
            Name = name;
            return Name;
        }
    }
}