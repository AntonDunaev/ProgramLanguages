// задача 1.
/*
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
    */
   // Задача 2.
   /*

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int secondnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int thirdnum = Convert.ToInt32(Console.ReadLine());
int Maxnumber = 0;
if(num == secondnum||secondnum == thirdnum)
     Console.WriteLine("Inputed nubers are equal.");
     else
     {
         if(num>Maxnumber)
         Maxnumber=num;
         if(secondnum>Maxnumber)
         Maxnumber=secondnum;
         if(thirdnum>Maxnumber)
         Maxnumber=thirdnum; 
         Console.WriteLine("Max number is " + Maxnumber);
     }
 */
 // Задача 3.
 Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int chast = 0; 
chast = num/2;
if(num == chast*2)
   Console.WriteLine("Number is even.");
   else 
   Console.WriteLine("Number is odd.");


  

  
      

    