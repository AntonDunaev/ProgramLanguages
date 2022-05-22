//Домашняя работа после 3 семинара.
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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
*/
// Задача. Написать программу, которая находит расстояние между двумя точками в 3D пространстве.
double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2 - y1)*(y2 - y1) + (z2-z1)*(z2-z1));    
}
Console.Write("Введите значение  по оси Х для первой точки: ");
int xFirstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси Y для первой точки: ");
int yFirstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение  по оси Z для первой точки: ");
int zFirstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение  по оси Х для второй точки: ");
int xSecondDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси Y для второй точки: ");
int ySecondDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси z для второй точки: ");
int zSecondDot = Convert.ToInt32(Console.ReadLine());
double dist = FindDistance(xFirstDot, yFirstDot, zFirstDot, xSecondDot, ySecondDot, zSecondDot);
Console.WriteLine("Расстояние от первой точки до второй " + dist);
