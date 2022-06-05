
//int[] CreateRandomeArray(int size, int min, int max)
/*
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
int CountElements(int[] array)
{
    int evenCount = 0;  //счётчик четных чисел
    int oddCount = 0; //счётчик нечетных чисел

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        evenCount ++;
        else
        oddCount ++;
    }
    return evenCount;
   // Console.WriteLine("Количество чётных элементов: " + evenCount);
   // Console.WriteLine("Количество нечётных элементов: " + oddCount);
}
int SumOfElements(int[] array)
{
    int evenSum = 0;  //сумма четных чисел
    int oddSum = 0; //сумма нечетных чисел

    for(int i = 1; i < array.Length; i++)
    {
        if(i % 2 == 0)
        evenSum = evenSum + array[i];
        else
        oddSum = oddSum + array[i];
    }
    return oddSum;
   // Console.WriteLine("Сумма чётных элементов: " + evenSum);
   // Console.WriteLine("Сумма нечётных элементов: " + oddSum);
}
int FindMaxElements(int[] array)
{
    int max=0;  
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
    return max;
}
int FindMinElements(int[] array)
{
    int min=array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];

    }
    return min;
}
*/
// Задача 1. Написать цикл который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
void DegreeOfNumber(int a, int b)
{
    int degNum = 1;
   for(int i = 0; i < b; i++)
   {
       degNum = degNum * a;
   }
   Console.Write(degNum);
}
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение степени, в котороую вы хотите произвести чилсо: ");
int y = Convert.ToInt32(Console.ReadLine());
DegreeOfNumber(x, y);
