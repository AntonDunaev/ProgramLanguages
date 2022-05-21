// Семинар 3.
//Задача 1
/*
int FindQvart(int x, int y)
{
    if(x>0 && y >0)
        return 1;
    else if(x<0 && y>0)
        return 4;
    else if(x>0 && y<0)
        return 2;
    else if(x<0 && y<0)
        return 3;
    else
        return 0;    
}
Console.Write("Введите значение по оси Х: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси Y: ");
int yDot = Convert.ToInt32(Console.ReadLine());
int qvartNum = FindQvart(xDot, yDot);
if (qvartNum == 0)
Console.WriteLine("точка находится на осях");
else
Console.WriteLine("номер четверти " + qvartNum);
*/
// Задача 2. Определить координаты точки по четверти
/*void FindDot(int q)
{
    if(q == 1)
    Console.WriteLine("Координаты точек в заданной области находятся в пределах :x>0 и y >0");
        else if(q == 2)
        Console.WriteLine("Координаты точек в заданной области находятся в пределах : x>0 && y<0");
        else if( q == 3)
        Console.WriteLine("Координаты точек в заданной области находятся в пределах : x<0 && y<0");
        else if(q == 4)
        Console.WriteLine("Координаты точек в заданной области находятся в пределах : x<0 && y>0");
        else
        Console.WriteLine("Вводимые данные некорректны, четверть с таким номером не существует");    
}
Console.Write("Введите номер четверти: ");
int qvartNum = Convert.ToInt32(Console.ReadLine());
FindDot(qvartNum);
*/
//Задача 3. Найти расстояние между точками по их координатам.
/*
double FindDistance(int x, int y, int z, int s)
{
    return Math.Sqrt((z-x)*(z-x) + (s - y)*(s - y));    
}
Console.Write("Введите значение  по оси Х для первой точки: ");
int xFirstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси Y для первой точки: ");
int yFirstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение  по оси Х для второй точки: ");
int xSecondDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси Y для второй точки: ");
int ySecondDot = Convert.ToInt32(Console.ReadLine());
double dist = FindDistance(xFirstDot, yFirstDot, xSecondDot, ySecondDot);
Console.WriteLine("Расстояние от первой тоски до второй " + dist);
*/
// Задача 3. Вывести таблицу квадратов
void qardNumber(int x)
{
    int count = 1;
    Console.Write(x + " -> ");
    while(count <= x)
    {
    Console.Write(count*count + ", ");
    count ++;
    }
}
Console.Write("Введите натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());
qardNumber(num);






