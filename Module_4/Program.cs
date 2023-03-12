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
            Console.WriteLine("");
            Console.WriteLine("");


            Console.ReadKey();
        }

        static (string name, string sername, int age, bool pet, int petcount, string[] petnames) anketa()
        {
            (string name, string sername, int age, bool pet, int petcount, string[] petnames) anketa;
            anketa.petcount = 0;
            anketa.petnames[0] = "fgfg";
            Console.WriteLine("Введите своe имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            anketa.sername = Console.ReadLine();
            Console.WriteLine("Введите свой возраст цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Введите количество животных: ");
                anketa.petcount = Convert.ToInt32(Console.ReadLine());
                anketa.petnames = petNames(anketa.petcount);
            }
           
                
            

            return (anketa.name, anketa.sername, anketa.age, anketa.pet, anketa.petcount, anketa.petnames);
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
        }
    }
    