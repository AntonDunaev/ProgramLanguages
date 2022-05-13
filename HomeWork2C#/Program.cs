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
void DontShowSecond()
{
    int num = new Random().Next(100, 999);
    int firstNum = num / 100;
    int secondNum = num % 10;
    Console.Write(num + "->");
    Console.Write(firstNum);
    Console.Write(secondNum);
}
Console.WriteLine("Задача 1. Не показовать второе число.");
DontShowSecond();
// Задача 2.
/*int DelitNeDelit()
{
    int firstNum = new Random().Next(80, 100);
    int secondNum = new Random().Next(1, 20);
    int chastnoe = firstNum / secondNum;
    int delimoe = chastnoe * secondNum;
    int ostatok = firstNum % secondNum;
    if (firstNum == delimoe)
    {
        Console.WriteLine("Первое число делится на второе без остатка. Частное равно  ");
        return chastnoe;
    }
    else
    {
        Console.WriteLine("Первое число делится на второе c остатком ");
        return  ostatok;
            }
}
int a = DelitNeDelit();
Console.WriteLine(a);
*/
//Console.Write("Input first integer number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input second integer number: ");
//int secondnum = Convert.ToInt32(Console.ReadLine());
