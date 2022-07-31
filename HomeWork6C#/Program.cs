// Задача. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше  0 ввёл пользователь.
int[] CreateConsoleArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива с индексом: " + i);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
       
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
void CountNaturalElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count ++;
    }
     Console.WriteLine("В данном массиве положительных чисел: " + count);
}


Console.WriteLine("Задайте желаемое количество чисел массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateConsoleArray(size);
Console.WriteLine("Заполнение массива завершено. Полученный массив: ");
ShowArray(newArray);
Console.WriteLine();
CountNaturalElements(newArray);






