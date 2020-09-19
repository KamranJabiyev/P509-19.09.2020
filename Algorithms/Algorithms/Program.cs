using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3-e ve 7-e bolunen ededler
            //int m = 924;
            //if (m % 21 == 0)
            //{
            //    Console.WriteLine("3-e ve 7-e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("3-e ve 7-e Bolunmur");
            //}
            #endregion

            #region Qiymetlendirme
            //int result = 81;

            //if(result<=100 && result >= 0)
            //{
            //    if (result <= 100 && result >= 91)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else if(result <= 90 && result >= 81)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else if (result <= 80 && result >= 71)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (result <= 70 && result >= 61)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (result <= 60 && result >= 51)
            //    {
            //        Console.WriteLine("E");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kesildiniz");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //}
            #endregion

            #region n-den m-e qeder ededlerin yazilmasi
            //int n = -2;
            //int m = 10;

            //for (int i = n; i <= m; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region n-den m-e qeder cut ededleri yazdirmaq

            //int n = -20;
            //int m = 10;

            //int i = n;
            //while (i <= m)
            //{
            //    if (i % 2 == 0 && i!=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //for (int i = n; i <=m; i++)
            //{
            //    if (i % 2 == 0 && i!=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region n-den m-e qeder tek ededlerin sayi
            //int n = 3;
            //int m = 7;

            //int count = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region n ededinin musbet bolenlerini tapmaq
            //int n = -8;
            //if (n < 0)
            //{
            //    n*=(-1);
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region x-ededinin y-ustunu tapmaq
            //int x = 2;
            //int y = 4;
            //int result = 1;
            //for (int i = 0; i < y; i++)
            //{
            //    result *= x;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Array,object

            //string[] students = { "Aqil","Nigar","Kamran" };
            //int[] numbers = { 100, 200 };
            //string[] test = new string[3] { "","",""};
            //Console.WriteLine(students[2]);
            //Console.WriteLine(students.Length);

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //foreach (string item in students)
            //{
            //    Console.WriteLine(item);
            //}

            var obj = new
            {
                name="Aqil",
                surname="Bashirov",
                age=26
            };

            Console.WriteLine(obj.name);
            #endregion
        }
    }
}
