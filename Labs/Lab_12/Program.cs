using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
        class Shop : ICloneable, IComparer, IComparable
    {
        protected List<Product> allProducts = new List<Product>();

        public void AddGroccery(string name, int price)
        {
            allProducts.Add(new Groccery(new List<string>() {name}, new List<int>() {price}));
        }

        public void AddChemicals(string name, int price)
        {
            allProducts.Add(new Chemicals(new List<string>() {name}, new List<int>() {price}));
        }

        public void AddDrinks(string name, int price)
        {
            allProducts.Add(new Drinks(new List<string>() {name}, new List<int>() {price}));
        }

        public void ShowInf()
        {
            foreach (var s in allProducts)
            {
                Console.WriteLine("Names: ");
                foreach (var nam in s.Names)
                {
                    Console.Write($"{nam} ");
                }
                Console.WriteLine();
 
                Console.WriteLine("Prices: ");
                foreach (var pri in s.Prices)
                {
                    Console.Write($"{pri} ");
                }
                Console.WriteLine('\n');
            }
        }
        
        public object DeepClone()
        {
            return new Shop {allProducts = this.allProducts};
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int Compare(object obj1, object obj2)
        {
            Product x = obj1 as Product;
            Product y = obj2 as Product;
            
            if (x.Names.Count > y.Names.Count) return 1;
            else if (x.Names.Count < y.Names.Count) return -1;
            else return 0;
        }

        public int CompareTo(object obj)
        {
            Product p = obj as Product;
            return p.Names.Count.CompareTo(p.Names.Count);
        }
        
    }

    abstract class Product
    {
        private List<string> _names; // List of product names
        private List<int> _prices; // List of product prices

        public List<string> Names
        {
            get { return _names; }
            set { _names = value; }
        }

        public List<int> Prices
        {
            get { return _prices; }
            set { _prices = value; }
        }

        public Product()
        {
            _names.Add("No name");
            _prices.Add(0);
        }

        public Product(List<string> names)
        {
            Names = names;
        }

        public Product(List<string> names, List<int> prices)
        {
            Names = names;
            Prices = prices;
        }

        protected abstract void changePrice(int price, int idx); // change price by List index
        protected abstract void changeName(string name, int idx); // change name by List index
    }


    class Groccery : Product
    {
        private List<string> names;
        private List<int> prices;

        public Groccery()
        {
            names.Add("No name");
            prices.Add(0);
        }
        
        public Groccery(List<string> names, List<int> prices) : base(names, prices)
        {
        }

        protected override void changeName(string name, int idx)
        {
            names[idx] = name;
        }

        protected override void changePrice(int price, int idx)
        {
            prices[idx] = price;
        }
    }

    class Chemicals : Product
    {
        private List<string> names;
        private List<int> prices;


        public Chemicals()
        {
            names.Add("No name");
            prices.Add(0);
        }

        public Chemicals(List<string> names, List<int> prices) : base(names, prices)
        {
        }

        protected override void changeName(string name, int idx)
        {
            names[idx] = name;
        }

        protected override void changePrice(int price, int idx)
        {
            prices[idx] = price;
        }
    }

    class Drinks : Product
    {
        private List<string> names;
        private List<int> prices;

        public Drinks()
        {
            names.Add("No name");
            prices.Add(0);
        }

        public Drinks(List<string> names, List<int> prices) : base(names, prices)
        {
        }

        protected override void changeName(string name, int idx)
        {
            names[idx] = name;
        }
        
        protected override void changePrice(int price, int idx)
        {
            prices[idx] = price;
        }
    }
    
    interface ICloneable
    {
        object DeepClone();
        object Clone();
    }
    
    interface IComparable
    {
        int CompareTo(object obj);
    }

    interface IComparer
    {
        int Compare(object obj1, object obj2);
    }

    interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}