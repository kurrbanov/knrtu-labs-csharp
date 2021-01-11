using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop Auchan = new Shop();
            
            Auchan.AddGroccery(new List<string> {"Bread", "Sugar", "Banana"}, new List<int> {30, 20, 80});

            Auchan.AddDrinks(new List<string> {"Water"}, new List<int> {39});
            
            Auchan.AddChemicals(new List<string> {"Powder", "Paper"}, new List<int> {500, 150});

            //Auchan.ShowInf();
            
            Shop Lenta = Auchan.DeepClone();
            
            Console.WriteLine($"Hash code Auchan: {Auchan.GetHashCode()}");
            Console.WriteLine($"Hash code Lenta: {Lenta.GetHashCode()}");
            
            Lenta.SetProduct(2, 1, "Detergent", 800);
            
            Console.WriteLine('\n');
            
            Lenta.allProducts.Sort();
            Lenta.ShowInf();
            Console.WriteLine();

            //Auchan.allProducts.Sort(new ProdCmp());
            Auchan.ShowInf();

        }
    }
    

    class Shop : ICloneable, IEnumerable
    {
        public List<Product> allProducts = new List<Product>();
        
        
        public void AddGroccery(List<string> name, List<int> price)
        {
            allProducts.Add(new Groccery(name, price));
        }

        public void AddChemicals(List<string> name, List<int> price)
        {
            allProducts.Add(new Chemicals(name, price));
        }

        public void AddDrinks(List<string> name, List<int> price)
        {
            allProducts.Add(new Drinks(name, price));
        }

        public void SetProduct(int idxProd, int idxType, string name, int price)
        {
            Product p = allProducts[idxProd];
            p.Names[idxType] = name;
            p.Prices[idxType] = price;
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

        public Shop DeepClone()
        {
            List<Product> deepList = new List<Product>();

            foreach (var prod in allProducts)
            {
                Product newProd = prod.Clone();
                deepList.Add(newProd);
            }

            return new Shop {allProducts = deepList};
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        public IEnumerator GetEnumerator()
        {
            return new ShopEnum(allProducts);
        }
    }

    class ShopEnum : IEnumerator
    {
        private List<Product> names;
        private int idx = -1;

        public ShopEnum(List<Product> names)
        {
            this.names = names;
        }

        public object Current
        {
            get
            {
                if (idx == -1) return names[0];
                else if (idx >= names.Count) return names[names.Count - 1];
                return names[idx];
            }
        }

        public bool MoveNext()
        {
            if (idx < names.Count - 1)
            {
                idx++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
    
    
    abstract class Product : IComparable, IComparable<Product>
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

        public int CompareTo(object obj)
        {
            Product p = obj as Product;
            return this.Names.Count.CompareTo(p.Names.Count);
        }

        public int CompareTo(Product obj)
        {
            return this.Names.Count.CompareTo(obj.Names.Count);
        }

        public Product Clone()
        {
            return MemberwiseClone() as Product;
        }

        protected abstract void changePrice(int price, int idx); // change price by List index
        protected abstract void changeName(string name, int idx); // change name by List index
    }


    class ProdCmp : IComparer<Product>, IComparer
    {
        public int Compare(Product x, Product y)
        {
            if (x.Names.Count < y.Names.Count) return 1;
            if (x.Names.Count > y.Names.Count) return -1;
            else return 0;
        }

        public int Compare(object obj1, object obj2)
        {
            Product x = obj1 as Product;
            Product y = obj2 as Product;

            if (x.Names.Count < y.Names.Count) return 1;
            if (x.Names.Count > y.Names.Count) return -1;
            else return 0;   
        }
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
        Shop DeepClone();
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

    interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}