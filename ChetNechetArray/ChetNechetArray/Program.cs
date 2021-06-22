using System;

namespace ChetNechetArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Введение пользователем количества элементов
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyArray array = new MyArray(n); // создание переменной массива и присвоение ей ссылки на экземпляр класса массива

            Console.WriteLine('\n' + "Исходный массив:");
            array.Show(); // вывод исходного массива

            Console.WriteLine('\n' + "Полученный массив:");
            array.DoubleChetOnNechetElements(); // удвоение чётных элементов, стоящих на нечётных местах
            array.Show(); // вывод изменённого массива

            Console.WriteLine('\n' + "Максимальный нечётный элемент, стоящий на чётном месте:");
            array.MaxNechetOnChetElement(); // поиск и вывод максимального нечётного элемента, стоящего на чётном месте
        }
    }
}
