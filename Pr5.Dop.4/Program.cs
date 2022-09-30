using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 34; // присвоение лок.переменной "name" строкового типа "string"; присвоние лок.переменной "age" целого типа "int".
            double height = 1.7; //присвоение вещественного типа "double" лок.переменной "height".
            Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}м", name, height, age); Console.ReadKey(); // вывод на экран имени, возраста и роста с параметрами представляющими значения, которые могут быть встроенны в строку(name, height, age);
        }
    }
}
