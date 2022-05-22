// семинар №4
//Задача 1
/*
int NaturalSum(int a)
{
    int sum = 0;

    if(a < 1) return 0;
    else
    {
       for(int i = 1; i <= a; i++)
       {
           sum = sum + i;
           //sum += i;  строка выполняет то же действие, что и предыдущая строка
       } 
    }
    return sum;
}
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел : " + NaturalSum(num));
*/
// Задача 2. Написать программу, которая принимает на вход число, и выдает сообщение сколько цифр в числе.
/*
int GetDigitAmount(int num)
{
    int count = 0;
    while(num > 0)
    {
    num = num/10;
    count ++;
    }
    return count;
}
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колчисетсво разрядов: " + GetDigitAmount(number));
*/
// Работа с массивами.
//Метод создания случайного одномерного массива.
/*
Int[] CreateRandomeArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
*/

//метод создания массива вручную.
/*
Int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите" + i + "элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

//Метод вывода массива
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
*/

// Задача 3. Задача написать программу, которая вычисляет факториал числа.
/*int Factorial(int a)
{
    int fact = 1;

    if(a < 1) return 0;
    else
    {
       for(int i = 1; i <= a; i++)
       {
           fact = fact * i;
           //sum += i;  строка выполняет то же действие, что и предыдущая строка
       } 
    }
    return fact;
}
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Факториал числа " + num +" равен : " + Factorial(num));
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите" + i + "элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

//Метод вывода массива
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

//Метод созания случайного одномрного массива.
int[] CreateRandomeArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        plusSum += array[i];
        else
        minusSum += array[i];
    }
    Console.WriteLine("Сумма положительных элементов: " + plusSum);
    Console.WriteLine("Сумма отрицательных элементов: " + minusSum);
    
}


int[] myArray = CreateRandomeArray(8, 0, 1);
ShowArray(myArray);
