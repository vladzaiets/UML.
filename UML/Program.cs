using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zamovnyk;

namespace UML
{
    class Program
    {
        static void Main()
        {
            // Створення через конструктор з параметрами
            Zamovnyk z1 = new Zamovnyk("0987654321", "Іваненко Іван Іванович", "ivan@gmail.com");
            z1.ShowInfo();

            // Створення через властивості
            Zamovnyk z2 = new Zamovnyk();
            z2.PIB = "Петренко Петро Петрович";
            z2.Telefon = "0501234567";
            z2.Email = "petro@gmail.com";
            z2.ShowInfo();

            MyString str1 = new MyString();
            Console.Write("Введіть рядок: ");
            str1.ReadFromConsole();  // <<

            MyString str2 = new MyString(" + Додано текст");
            MyString result = str1 + str2;  // +

            Console.Write("Результат: ");
            result.WriteToConsole();  // >>

            // Присвоєння
            MyString copy = new MyString();
            copy.Assign(result);

            Console.Write("Копія: ");
            copy.WriteToConsole();


        }


    }

}
