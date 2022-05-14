//Домашняя работа после второго семинара.
void ShowSecond()
{
    int num = new Random().Next(100, 999);
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    Console.Write(num + "->");
    Console.Write(secondNum);
    }
Console.WriteLine("Задача 1. Показать второе число.");
ShowSecond();