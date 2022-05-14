/* void ShowNumber()
{
  int num = new Random().Next(10, 99);
  int firstNum = num / 10;
  int secondNum = num % 10;
  Console.Write(num + "->");
    if (firstNum > secondNum)
    {
        Console.Write(firstNum);
    }
    else
    {
        Console.Write(secondNum);
    }
}
ShowNumber();
*/
// метод с возвратом значения.
/* int ShowNumber() // для возврата значения необходим тип int, т.к. с типом void ничего вернуть не получится.
{
  int num = new Random().Next(10, 99);
  int firstNum = num / 10;
  int secondNum = num % 10;
  Console.Write(num + "->");
    if (firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}
int a = ShowNumber();
Console.WriteLine(a);
*/
// Задача 1.
/*
void DontShowSecond()
{
    int num = new Random().Next(100, 999);
    int firstNum = num / 100;
    int secondNum = num % 10;
    int num3 = firstNum * 10 + secondNum;
    Console.Write(num + "->");
    Console.Write(num3);
    }
Console.WriteLine("Задача 1. Не показовать второе число.");
DontShowSecond();
*/
// Задача 2.
/*
void DelitNeDelit()
{
    Console.WriteLine("Input first integer number: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second integer number: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    int ostatok = firstNum % secondNum;
    if (firstNum % secondNum == 0)
    {
        Console.WriteLine(firstNum + "is multiple of " + secondNum);
    }
    else
    {
        Console.WriteLine(firstNum + "is not multiple of " + secondNum);
        Console.WriteLine("remain is " + ostatok);
    }
}
DelitNeDelit();
*/
// Задача 3.
/*
void Multiplicity(int num)
{
     if (num % 7 == 0 && num % 23 == 0)
    {
       Console.Write(num + " is multiple of 7 and 23"); 
    }
    else
    {
       Console.Write(num + " is NOT multiple of 7 and 23");
    }
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Multiplicity(num);
*/
// Задача 4.
/*
void Sqr(int n1, int n2)
{
    if (n1 == n2*n2)
    {
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");
}
Console.WriteLine("Input first integer number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Sqr(firstNum, secondNum);
*/



