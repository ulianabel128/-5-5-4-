using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5_практика__другое_5_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool ok = false;

            do
            {
                Console.WriteLine("Введите n");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out n);
                if (n < 1) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод");
            }
            while (!ok);
            ok = false;

            int[,] mas = new int[n, n];
            int i = -1;
            int j = -1;


            for (int x = 0; x < mas.GetLength(0); x++)
            {
                for (int y = 0; y < mas.GetLength(1); y++)
                {
                    do
                    {
                        Console.WriteLine("Введите элемент "+(x+1)+" строчики, "+(y+1)+" столбца");
                        string user = Console.ReadLine();
                        ok = int.TryParse(user, out mas[x,y]);
                        if (!ok) Console.WriteLine("Неверный ввод");
                    }
                    while (!ok);
                    ok = false;
                }
            }

            for (int x = 0; x < mas.GetLength(0); x++)
            {
                for (int y = 0; y < mas.GetLength(1); y++)
                    Console.Write(mas[x, y] + " ");
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("Введите номер i-строчки, которую нужно удалить");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out i);
                if ((i < 1) || (i > n)) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод");
            }
            while (!ok);
            ok = false;

            do
            {
                Console.WriteLine("Введите номер j-столбец, которую нужно удалить");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out j);
                if ((j < 1) || (j >n)) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод");
            }
            while (!ok);
            ok = false;

            int jj = j-1;
            int ii = i-1;

            while (ii != n-1)
            {
                for (int x = 0; x < n-1; x++)
                {
                    mas[ii, x] = mas[ii + 1,x];
                }
                ii= ii+ 1;
            }

            while (jj != n - 1)
            {
                for (int x = 0; x < n-1; x++)
                {
                    mas[x,jj] = mas[x,jj+1];
                }
                jj = jj + 1;
            }

            Console.WriteLine("После удаления:");
            for (int x = 0; x < mas.GetLength(0)-1; x++)
            {
                for (int y = 0; y < mas.GetLength(1)-1; y++)
                    Console.Write(mas[x, y] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
