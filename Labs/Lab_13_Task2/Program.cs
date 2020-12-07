using System.IO;

namespace Lab_13_Task2
{
    delegate void SendInfo(object sender, Car porsche);

    class Program
    {
        static void Main(string[] args)
        {
            Radar ment = new Radar();
            ment.Notify += STSI.Penalty;
            ment.CheckSpeed("Porsche 911 Turbo S", "Курбанов Радиф", "К013РР 116RUS", 320);
        }
    }
    
    class Car
    {
        public string Model { get; set; }
        public string NamePerson { get; set; }
        public string Number { get; set; }

        public Car(string model, string namePerson, string number)
        {
            Model = model;
            NamePerson = namePerson;
            Number = number;
        }
    }
    
    class Radar
    {
        private int _speedLimit = 90;

        public event SendInfo Notify;
        
        public void CheckSpeed(string model, string namePerson, string number, int currentSpeed)
        {
            if (currentSpeed > _speedLimit)
            {
                Notify?.Invoke(this, new Car(model, namePerson, number));
            }
        }
    }
    
    class STSI
    {
        public static void Penalty(object sender, Car Porsche)
        {
            string source = @"C:\Users\user\RiderProjects\learnpr1\output.txt"; // свой путь файла сами укажите камон.
            using (FileStream fs = new FileStream(source, FileMode.Open))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine("Штраф");
                    sr.WriteLine($"ФИО: {Porsche.NamePerson}");
                    sr.WriteLine($"Марка авто: {Porsche.Model}");
                    sr.WriteLine($"Номер авто: {Porsche.Number}");
                }
            }
        }
    }
}