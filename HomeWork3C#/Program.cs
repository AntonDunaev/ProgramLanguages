//Домашняя работа после 3 семинара.
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void TestPolindrom(string numbers)
{
    int length = numbers.Length;
    if (length > 5)
         Console.WriteLine("В числе больше 5 знаков." );
         else
         if(length < 5)
            Console.WriteLine("В числе меньше 5 знаков. ");
        else
        if(numbers[0] == numbers[4] && numbers[1] == numbers[3])
        Console.WriteLine("Число является палиндромом.");
        else
            Console.WriteLine("Третьей цифры нет");
}        
Console.WriteLine("Задача 19. Проверить является ли число полнидромом.");
Console.WriteLine("Введите пятизначное целое число: ");
string num = Console.ReadLine();
TestPolindrom(num);
