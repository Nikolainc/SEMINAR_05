class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 32

        //**Задача 32:**Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
        //[-4, -8, 8, 2]-> [4, 8, -8, -2]

        //int[] array = NewArray(10, -9, 9);

        //PrintArray(array);

        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = -array[i];
        //}

        //Console.WriteLine();
        //PrintArray(array);

        #endregion

        #region Задача 33

        //**Задача 33:**Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
        //4; массив[6, 7, 19, 345, 3]->нет
        //3; массив[6, 7, 19, 345, 3]->да

        //int[] array = NewArray(5, 0, 9);

        //int value;
        //Console.Write("Введите число: ");
        //int.TryParse(Console.ReadLine(), out value);
        //bool finded = false;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] == value)
        //    {
        //        Console.WriteLine($"под индексом {i} нашлось число {value}");
        //        finded = true;
        //    }
        //}

        //if (!finded)
        //    Console.WriteLine("Число не нашлось в массиве");

        //Console.Write("Наш массив: ");
        //PrintArray(array);

        #endregion

        #region Задача 35

        //**Задача 35:**Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке[10, 99].
        //*Пример для массива из 5, а не 123 элементов.В своём решении сделайте для 123 *
        //[5, 18, 123, 6, 2]-> 1
        //[1, 2, 3, 6, 2]-> 0
        //[10, 11, 12, 13, 14]-> 5

        //int[] array = NewArray(123, 1, 1000);
        //PrintArray(array);
        //int count = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 9 && array[i] < 100)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        #endregion

        #region Задача 37
        //**Задача 37:**Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
        //[1 2 3 4 5]-> 5 8 3
        //[6 7 3 6]-> 36 21

        //int[] array = NewArray(5, 1, 9);
        //PrintArray(array);
        //int[] array2;
        //if (array.Length % 2 != 0)
        //{
        //    array2 = new int[array.Length / 2 + 1];
        //}
        //else
        //{
        //    array2 = new int[array.Length / 2];
        //}
        //for (int i = 0; i < array.Length / 2; i++)
        //{
        //    array2[i] = array[i] * array[array.Length - i - 1];
        //    Console.WriteLine(array2[i]);
        //}
        //if (array.Length % 2 != 0)
        //{
        //    array2[array2.Length - 1] = array[array.Length / 2];
        //    Console.WriteLine(array2[array2.Length - 1]);
        //}

        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 34
        //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
        //[345, 897, 568, 234] -> 2

        //int[] array = NewArray(5, 100, 1000);
        //PrintArray(array);
        //int count = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] % 2 == 0)
        //        count++;
        //}
        //Console.WriteLine($"В массиве {count} четных чисел");

        #endregion

        #region Задача 36
        //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
        //[3, 7, 23, 12] -> 19
        //[-4, -6, 89, 6]-> 0

        //int[] array = NewArray(5, -10, 10);
        //PrintArray(array);
        //int posSum = 0;

        //foreach (var item in array)
        //{
        //    if (item % 2 != 0)
        //    {
        //        posSum += item;
        //    }
        //}
        //Console.WriteLine($"Сумма нечетных чисел в массиве {posSum}");

        #endregion

        #region Задача 38
        //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        //[3 7 22 2 78] -> 76

        //int[] array = NewArray(5, 1, 100);
        //PrintArray(array);
        //int maxNumber = array[0];
        //int minNumber = array[0];

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > maxNumber)
        //    {
        //        maxNumber = array[i];
        //    }
        //    else if (array[i] < minNumber)
        //    {
        //        minNumber = array[i];
        //    }
        //}
        //Console.Write($"Разница между {maxNumber} и {minNumber}: ");
        //Console.WriteLine(maxNumber - minNumber);

        #endregion

        #endregion
    }

    static int[] NewArray(int size, int min, int max)
    {
        int[] array = new int[size];

        Random r = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = r.Next(min, max + 1);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}