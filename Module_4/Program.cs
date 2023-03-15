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
            AnketaResult(AnketaKorteg);
        }

        static (string name, string sername, int age, bool pet, int petcount, string[] petnames, int colorcount, string[] colors) anketa()
        {
            (string name, string sername, int age, bool pet, int petcount, string[] petnames, int colorcount, string[] colors) anketa;
            anketa.petcount = 0;
            anketa.colorcount = 0;
            anketa.age = 0;
            string strtemp = "";
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
            while (iscorrectage == false)
            {
                Console.WriteLine("Введите свой возраст цифрами (от 1 до 150): ");
                strtemp = Console.ReadLine();
                iscorrectage = CheckNumber(strtemp, 150);
            }
            anketa.age = Convert.ToInt32(strtemp);

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
                strtemp="";
                while (iscorrectpetcount == false)
                {
                    Console.WriteLine("Введите количество животных (от 1 до 5): ");
                    strtemp=Console.ReadLine();
                    iscorrectpetcount = CheckNumber(strtemp, 5);
                }
                anketa.petcount = Convert.ToInt32(strtemp);
                petnames = petNames(anketa.petcount);


            }

            strtemp = "";
            while (iscorrectcolorcount == false)
            {
                Console.WriteLine("Введите количество цветов (от 1 до 3): ");
                strtemp = Console.ReadLine();
                iscorrectcolorcount = CheckNumber(strtemp, 3);
            }
            anketa.colorcount = Convert.ToInt32(strtemp);
            colors = Colors(anketa.colorcount);





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
        static bool CheckNumber(string number, int maxnumber)
        {
            int tempnumber;
            bool correctint = false;
            bool correctnumer =false;
            correctint = int.TryParse(number, out tempnumber);
            if (tempnumber < 1 | tempnumber > maxnumber | correctint == false)
            {
                correctnumer = false;
            }
            else
            {
                correctnumer = true;
            }
            return correctnumer;
        }
        static void AnketaResult((string name, string sername, int age, bool pet, int petcount, string[] petnames, int colorcount, string[] colors) AnketaKortegL)
        {
            Console.WriteLine("\n\n\tРезультаты анкетирования:");
            Console.WriteLine("Ваше имя: {0}", AnketaKortegL.name);
            Console.WriteLine("Ваша фамилия: {0}", AnketaKortegL.sername);
            Console.WriteLine("Ваш возраст: {0}", AnketaKortegL.age);
            if (AnketaKortegL.pet == true)
            {
                Console.WriteLine("Домашние животные:");
                for (int i = 0; i <= AnketaKortegL.petcount - 1; i++)
                {
                    Console.WriteLine((i + 1) + " животное: " + AnketaKortegL.petnames[i]);
                }
            }
            else
            {
                Console.WriteLine("Домашних животных нет");
            }
            Console.WriteLine("Любимые цвета:");
            for (int i = 0; i <= AnketaKortegL.colorcount - 1; i++)
            {
                Console.WriteLine((i + 1) + " цвет: " + AnketaKortegL.colors[i]);
            }

            Console.ReadKey();
        }
        }
    }
    