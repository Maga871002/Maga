using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class dog
    {

        public string Nickname { get; set; }
        public string Breed { get; set; }
        public double Age { get; set; }

        public dog()
        {
            Nickname = "";
            Breed = "";
            Age = 0;
        }

        public void vvod()
        {
            Console.WriteLine("Добавление новой собаки => ");
            Console.Write("Кличка: ");
            Nickname = Console.ReadLine();
            Console.Write("Порода: ");
            Breed = Console.ReadLine();
            Console.Write("Возраст: ");
            Age = Convert.ToDouble(Console.ReadLine());
        }

        public void vivod()
        {
            Console.WriteLine("Кличка: {0}, Порода: {1}, Возраст {2}", Nickname, Breed, Age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            dog Dog = new dog();
            Dog.vvod();
            Dog.vivod();
            Console.ReadKey();
        }
    }
}
