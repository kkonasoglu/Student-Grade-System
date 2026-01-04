using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        bool loop = true;
        Console.WriteLine($"-----------------------------------------");
        Console.WriteLine($"Welcome to the Student information system");
        Console.WriteLine($"-----------------------------------------");
        Student yeniogrenci = new Student("Ahmet", "Çalışkan", 80, 90);
        Student yeniogrenci2 = new Student("Mehmet", "Tembel", 30, 40);
        Console.WriteLine($"Name: {yeniogrenci.Name} | Surname: {yeniogrenci.Surname} | MidTern: {yeniogrenci.MidTern} | Final: {yeniogrenci.Final}");
        Console.WriteLine($"Name: {yeniogrenci2.Name} | Surname: {yeniogrenci2.Surname} | MidTern: {yeniogrenci2.MidTern} | Final: {yeniogrenci2.Final}");
        Console.WriteLine($"--------------------------------");
        while (loop)
        {
            Console.WriteLine($"What do you want");
            Console.WriteLine($"----------------");
            Console.WriteLine("1: Choose ahmet");
            Console.WriteLine("2: Choose mehmet");
            Console.WriteLine("0: out");
            string choose = Console.ReadLine() ?? "";

            if (choose == "1")
            {
                yeniogrenci.FindAverage();
                yeniogrenci.PassOrNot();
            }
            else if (choose == "2")
            {
                yeniogrenci2.FindAverage();
                yeniogrenci2.PassOrNot();
            }
            else
            {
                loop = false;
                Console.WriteLine("Have a nice day :D...");
            }
        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public double MidTern;
        public double Final;
        public double Average;

        public Student(String adı, string soyadı, double vizesi, double finali)
        {
            Name = adı;
            Surname = soyadı;
            MidTern = vizesi;
            Final = finali;
        }

        public void FindAverage()
        {

            Average = (MidTern * 0.4) + (Final * 0.6);
            Console.WriteLine($"this is the average: {Average}");
        }

        public void PassOrNot()
        {
            if (Average >= 50)
            {
                Console.WriteLine($"{Name} is pass the class");
            }
            else
            {
                Console.WriteLine($"{Name} is dip out");
            }
        }

    }

}