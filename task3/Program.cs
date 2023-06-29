// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = Prompt("Введите размерность массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
double[] array = GetArray(size, min, max);
Console.Write($"[{string.Join(" ",  array)}] --> ");
Console.Write(Difference(array));


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}  

double [] GetArray(int size, double min, double max)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        double rand = rnd.NextDouble();
        double val = min + rand * (max - min);
        result[i] = Math.Round(val, 2);
    }
    return result;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

double Difference (double[] arr)
{
    double max = arr [0];
    double min = arr [0];
    for (int i = 0; i < arr.Length; i++)  
    {
         if (max < arr[i])  
         {
             max = arr[i];
         }
         else if (min > arr[i])
         {
            min = arr[i];
         }
    }  
    double result = max - min;
    return result;
}

