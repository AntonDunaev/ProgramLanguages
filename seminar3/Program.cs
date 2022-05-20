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
void FindDot(int q)
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



