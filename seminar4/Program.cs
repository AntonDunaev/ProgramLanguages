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