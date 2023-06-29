// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}  

int [] GetArray(int size)
{
    int [] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int SearchArray (int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)  
    {
         if (arr[i]% 2 == 0)
            
            {
                result += 1;
            }
    }  
    return result;
}

int size = Prompt("Введите размерность массива: ");
int[] array = GetArray(size);
PrintArray(array);
Console.Write("-->");
Console.WriteLine(SearchArray(array));