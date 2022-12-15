// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

(int, int) MaxIMin (int[] array)
{
    int max = 0;
    int min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return (max, min);
}

const int LENGTH = 10;
const int LEFTRANGE = -100;
const int RIGHTRANGE = 100;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int Max, int Min) = MaxIMin(massive);
int difference = Max - Min;
Console.WriteLine($"Max = {Max}, Min = {Min}");
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива = {difference}");