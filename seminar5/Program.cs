﻿// Семинар 5
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
int[] ChangeNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] *= (-1);
    return array;
}
void FindNum(int[] array, int num)
{
 for(int i = 0; i < array.Length; i++)
 {
 if(num == array[i])
 {
 Console.WriteLine("Число " + num + " присутствует в массиве.");
 break;
 }
 else
 {
  Console.WriteLine("Число " + num + " отсутствует в массиве.");
  break;
   }
 }
}

//Задача 1. Создать массив, написать программу, которая скажет присутствует ли заданное число в массиве.
int[] myArray = CreateRandomeArray(10, -9, 10);
 Console.WriteLine("Введите число от -9 до 10 для поиска в массиве");
int number = Convert.ToInt32(Console.ReadLine());
FindNum(myArray, number);
ShowArray(myArray);









//Задача 2.Создать одномерный массив из 15 случайных чисел, 
//после чего найти количество элементов, находящихся в отрезке от 10  до 99.




//Задача 3. Найти произведение пар чисел (первое и последнее, второе и предпоследнее и т.д.)
// одномерного массива.