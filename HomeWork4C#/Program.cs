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
int[] myArray = CreateRandomeArray(8, 100, 999);
ShowArray(myArray);
Console.Write(" -> " + CountElements(myArray));


