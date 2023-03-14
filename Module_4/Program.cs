using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var AnketaKorteg = anketa();
            Console.WriteLine("Ваше имя: {0}", AnketaKorteg.name);
            Console.WriteLine("Ваша фамилия: {0}", AnketaKorteg.sername);
            Console.WriteLine("Ваш возраст: {0}", AnketaKorteg.age);
            if (AnketaKorteg.pet == true)
            {
                Console.WriteLine("Домашние животные:");
                for (int i = 0; i <= AnketaKorteg.petcount - 1; i++)
                {
                    Console.WriteLine((i + 1) + " животное: " + AnketaKorteg.petnames[i]);
                }
            }
            else
            {
                Console.WriteLine("Домашних животных нет");
            }
            Console.WriteLine("Любимые цвета:");
            for (int i = 0; i <= AnketaKorteg.colorcount - 1; i++)
            {
                Console.WriteLine((i + 1) + " цвет: " + AnketaKorteg.colors[i]);
            }
            

            Console.ReadLine();
        }

        static (string name, string sername, int age, bool pet, int petcount, string[] petnames, int colorcount, string[] colors) anketa()
        {
            (string name, string sername, int age, bool pet, int petcount, string[] petnames, int colorcount, string[] colors) anketa;
            anketa.petcount = 0;
            anketa.colorcount = 0;
            anketa.age = 0;
            string[] petnames = new[] { "-"};
            string[] colors = new[] { "-" };
            bool iscorrectage = false;
            bool iscorrectpetcount = false;
            bool iscorrectcolorcount = false;
            //anketa.petnames[0] = "fgfg";
            Console.WriteLine("Введите своe имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            anketa.sername = Console.ReadLine();
            while (iscorrectage == false | anketa.age < 1 | anketa.age > 255)
            {
                Console.WriteLine("Введите свой возраст цифрами: ");
                iscorrectage = int.TryParse(Console.ReadLine(), out anketa.age);
                //anketa.age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            var resultPet = Console.ReadLine();

            if (resultPet == "Да")
            {
                anketa.pet = true;
            }
            else
            {
                anketa.pet = false;
            }

            if (anketa.pet == true)
            {
                while (iscorrectpetcount == false | anketa.petcount < 1 | anketa.petcount > 5)
                {
                    Console.WriteLine("Введите количество животных (от 1 до 5): ");
                    iscorrectpetcount = int.TryParse(Console.ReadLine(), out anketa.petcount);
                    petnames = petNames(anketa.petcount);
                }
                
            }
            while (iscorrectcolorcount == false | anketa.colorcount < 1 | anketa.colorcount > 3)
            {
                Console.WriteLine("Введите количество животных (от 1 до 3): ");
                iscorrectcolorcount = int.TryParse(Console.ReadLine(), out anketa.colorcount);
                colors = Colors(anketa.colorcount);
            }





            return (anketa.name, anketa.sername, anketa.age, anketa.pet, anketa.petcount, petnames, anketa.colorcount, colors);
        }
        static string[] petNames(int pet_count)
        {
            string[] names = new string[pet_count];
            for (int i=0; i < pet_count; i++) 
            {
                Console.WriteLine("Введите кличку " + (i+1) + " животного:");
                names[i] = Console.ReadLine();
            }
            return names;   
        }
        static string[] Colors(int color_count)
        {
            string[] names = new string[color_count];
            for (int i = 0; i < color_count; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " цвет:");
                names[i] = Console.ReadLine();
            }
            return names;
        }
        static void AnketaResult(string[] AnketaKortegL)
        {
            //Console.WriteLine("Ваше имя: {0}", AnketaKortegL.name);
            //Console.WriteLine("Ваша фамилия: {0}", AnketaKortegL.sername);
            //Console.WriteLine("Ваш возраст: {0}", AnketaKortegL.age);
            //Console.WriteLine("");
            //Console.WriteLine("");


            Console.ReadKey();
        }
        }
    }
    