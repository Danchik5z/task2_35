using System;
using System.IO;

namespace task2_35
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Размер через мой алгоритм" + IntFileSize("file.txt"));
        }

        private static int IntFileSize(string name)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\NewDirectory1\\" + name);
                int sizeFile = 0;
                string text = File.ReadAllText(path); //я просто прохожусь по строкам, которые у меня получились и считаю кол-во символов
                foreach(char ch in text)             //Enter или перевод строки считается за 2 бита, и перевод строки в цикле делается за 2 итерации, так что всё совпадает
                {
                    sizeFile += 1;
                }
                FileInfo fileInfo = new FileInfo(path); //встроенная функция для проверки
                Console.WriteLine("Проверка размера файла через встроенную функцию: " + fileInfo.Length);
                return sizeFile;


            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                return -1;
            }
        }
    }
}