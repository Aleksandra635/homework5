//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
int [] array = GenerateArray(size, min, max);
Console.Write($"[{string.Join(", ", array)}] -> ");
Console.WriteLine(SumArray(array));

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}  

int [] GenerateArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

  void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int SumArray (int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        result += arr[i];
    }
    return result;
}