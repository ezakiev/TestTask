using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetNechetArray
{
    class MyArray
    {
        private int[] array; // сам массив
        private int n; // количество элементов
        public MyArray() // инициализация полей и заполнение массива
        {
            n = 10;
            array = new int[n];
            FillRandomArray();
        }

        public MyArray(int n) // создание массива с определённым числом элементов
        {
            this.n = n;
            array = new int[n];
            FillRandomArray();
        }

        public int N => n; // св-во для получения числа элементов
        public int[] Array => array; // св-во для получения массива

        private void FillRandomArray() // метод случайного заполнения массива
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                array[i] = rand.Next(1, 100);
        }

        public void Show() // печать массива в консоли
        {
            foreach (int el in array)
                Console.Write(el + " ");
            Console.WriteLine();
        }

        public void DoubleChetOnNechetElements() // метод удвоения чётных элементов, стоящих на нечётных местах
        {
            int counter = 0; // счётчик подходящих элементов
            for (int i = 0; i < n; i += 2)
                if (array[i] % 2 == 0)
                {
                    array[i] *= 2;
                    counter++;
                }
            if (counter == 0)
                Console.WriteLine("Нет чётных элементов, стоящих на нечётных местах");
        }

        public void MaxNechetOnChetElement() // метод поиска максимального нечётного элемента, стоящего на чётном месте
        {
            int max = -1; // начальный максимум
            for (int i = 1; i < n; i += 2)
                if (array[i] % 2 != 0 && array[i] > max)
                    max = array[i];
            if (max == -1)
                Console.WriteLine("Нет нечётных элементов, стоящих на чётных местах");
            else
                Console.WriteLine(max);
        }
    }
}
