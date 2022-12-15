// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int Count (int[] array)
{
    int kol = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] % 2 == 0)
       {
            kol ++;
       }
    }
    return(kol);
}

const int LENGTH = 10;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
int amount = Count(massive);
Console.WriteLine($"Количество чётных чисел = {amount}");
