using System;
using System.IO;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            product ball = new product("ball", "12342", 5);
            product phone = new product("iPhone", "2143123", 3);

            ball.changeKolvo(200);
            phone.changeName("Samsung");
            ball.changeChiper("dkjdld");
            phone.saveAll();
            ball.showAll();

            product sum = ball + phone;

            Console.WriteLine(sum.Value);

            if (ball > phone)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    
    // 8 variant
    class product
    {
        string name, chiper;
        uint kolvo;

        public product()
        {
            name = "No Name";
            chiper = "No chiper";
            kolvo = 0;
        }

        public product(string name, string chiper, uint kolvo)
        {
            this.name = name;
            this.chiper = chiper;
            this.kolvo = kolvo;
        }

        public void changeName(string name)
        {
            this.name = name;
        }

        public void changeChiper(string chiper)
        {
            this.chiper = chiper;
        }

        public void changeKolvo(uint kolvo)
        {
            this.kolvo = kolvo;
        }

        public string link = @"C:\Users\user\RiderProjects\learnpr1\output.txt";

        public void saveAll()
        {
            using (FileStream fs = new FileStream(link, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"Name: {name}");
                    sw.WriteLine($"Chiper: {chiper}");
                    sw.WriteLine($"Quantity: {kolvo}");
                }
            }
        }

        public void showAll()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Chiper: {chiper}");
            Console.WriteLine($"Quantity: {kolvo}");
        }

        public void set(string Name, string Chiper, uint Kolvo)
        {
            name = Name;
            chiper = Chiper;
            kolvo = Kolvo;
        }

        public uint Value
        {
            get { return kolvo; }

            set { kolvo = value; }
        }

        public string ValueName
        {
            get { return name; }
            set { name = value; }
        }

        public string valueChiper
        {
            get { return chiper; }
            set { chiper = value; }
        }

        public static product operator +(product a, product b)
        {
            return new product(a.name, a.chiper, a.Value + b.Value);
        }

        public static bool operator <(product a, product b)
        {
            return a.Value < b.Value;
        }

        public static bool operator >(product a, product b)
        {
            return a.Value > b.Value;
        }
    }
}