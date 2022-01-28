using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = "text.txt";   // txt просто сохранил здравствуйте 
            
           
            string fileText = File.ReadAllText(file1);
            Console.WriteLine(fileText);


            string greeting = Properties.Settings.Default.Greeting; //приветствие
            
            
            



            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            
            Console.WriteLine($"{greeting}, {userName}!");

            if (string.IsNullOrEmpty(Properties.Settings.Default.Year))
            {

                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.Year = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string Year = Properties.Settings.Default.Year;
            
            Console.WriteLine($"{Year}!");

            if (string.IsNullOrEmpty(Properties.Settings.Default.WhatYouDoing))
            {

                Console.WriteLine("Введите род деаятельности:");
                Properties.Settings.Default.WhatYouDoing = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string WhatYouDoing = Properties.Settings.Default.WhatYouDoing;
            
            Console.WriteLine($"{WhatYouDoing}!");
        }
    }
}
