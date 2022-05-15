//Домашняя работа после второго семинара.
// Задача 10. Показать вторую цифру трехзначного числа
/*void ShowSecond()
{
    int num = new Random().Next(100, 999);
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    Console.Write(num + "->");
    Console.Write(secondNum);
    }
Console.WriteLine("Задача 10. Показать второе число.");
ShowSecond();*/
// Задача 13. Вывести третью цифру и сообщить, что её нет.
void ShowThird(string numbers)
{
    int length = numbers.Length;
    if (length>=3)
    {
        Console.WriteLine("Третье число: " + numbers[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
       }
Console.WriteLine("Задача 13. Показать третье число.");
Console.WriteLine("Введите целое число: ");
string num = Console.ReadLine();
ShowThird(num);

//Задача 15. Написать программу про цифру и день недели.
/*void DenNedeli()
{
    Console.WriteLine("Введите число обозначающее день недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 7)
    {
        Console.WriteLine("Неверное число. В неделе всего 7 дней");
    }
    else
    {
        if (num > 0 && num < 6) 
        {
            Console.WriteLine("К сожалению будний день. (");
        }
        else
        {
           Console.WriteLine("Ура! выходные! Идём на рыбалку )))"); 
        }
    }
}
DenNedeli();*/




