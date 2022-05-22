// семинар №4
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
