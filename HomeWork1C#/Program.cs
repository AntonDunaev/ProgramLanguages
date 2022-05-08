// задача 1.
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int secondnum = Convert.ToInt32(Console.ReadLine());
if(num == secondnum)
     Console.WriteLine("Inputed nubers are equal.");
    else
    {
     if(num > secondnum)
        Console.WriteLine(" max number " + num);
        else
        Console.WriteLine("max number " + secondnum);
    }