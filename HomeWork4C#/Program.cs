// Домашнее задание после семинара №4.
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, коорая покажет количество чётных чисел в массиве. 
int[] CreateRandomeArray(int size, int min, int max)
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
/*
int[] myArray = CreateRandomeArray(8, 100, 999);
ShowArray(myArray);
Console.Write(" -> " + CountElements(myArray));
*/
// Задача 36. Задать одномерный массив случайных чисел. Найти сумму элементов, стоящих на нечётных позициях.

int[] myArray = CreateRandomeArray(4, 0, 30);
ShowArray(myArray);
Console.Write(" -> " + SumOfElements(myArray));


