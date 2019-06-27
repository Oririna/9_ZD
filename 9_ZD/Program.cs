using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ZD
{
    class Program
    {
        static void Main(string[] args)
        {
                // Объявляем массив
                int[] myArr = new int[5];
                // Инициализируем каждый элемент 
                myArr[0] = 4;
                myArr[1] = 5;
                myArr[2] = -10;
                myArr[3] = 1;
                myArr[4] = -9;

                Console.WriteLine("В правильном порядке: ");
                 // вывод элементов массива
                 foreach (int r in myArr)
                  Console.Write(r + " ");

            // Объявляем массив
            int[] myArr2 = new int[5];
            // Инициализируем каждый элемент 
            myArr2[0] = -9;
            myArr2[1] = 1;
            myArr2[2] = -10;
            myArr2[3] = 5;
            myArr2[4] = 4;

            Console.WriteLine("\nВ обратном порядке: ");
            // вывод элементов массива
            foreach (int r in myArr2)
                Console.Write(r + " ");

            // положительная сумма
            int PolSum = 0;
            for (int i = 1; i < myArr.Length; i++)
            {
                if (myArr[i] > 0)
                {
                    PolSum += myArr[i];
                }
            }
            if (PolSum != 0)
            {
                Console.WriteLine("\nСумма положительных элементов = " + PolSum);
            }
            else
            {
                Console.WriteLine("\nНет положительных элементов " + PolSum);
            }

            // отрицательная сумма
            int OtrSum = 0;
            for (int i = 1; i < myArr.Length; i++)
            {
                if (myArr[i] < 0)
                {
                    OtrSum += myArr[i];
                }
            }
            if (OtrSum != 0)
            {
                Console.WriteLine("\nСумма отрицательных элементов = " + OtrSum);
            }
            else
            {
                Console.WriteLine("\nНет отрицательных элементов " + OtrSum);
            }
        }
    }
}
