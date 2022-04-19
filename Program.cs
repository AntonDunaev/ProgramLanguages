/*Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result is " + num*num);
*/
// задача 2.
/*Console.Write("Input first integer number  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number  ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad = num2*num2;
if(num1 == quad)
{
    Console.WriteLine("First number is a quad of second number");
}
else
{
Console.WriteLine("First number is not a quad of second number");
}
*/
// Задача 3.
Console.Write("Input number of weekday  ");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 7 || day < 1)
    Console.WriteLine("Incorrect number of weekday!");

else 
{
if(day == 1)
   Console.WriteLine("It is Monday"); 
   if(day == 2)
    Console.WriteLine("It is Tuesday"); 
   if(day == 3)
    Console.WriteLine("It is Wednesday"); 
  if(day == 4)
    Console.WriteLine("It is Thursday"); 
   if(day == 5)
    Console.WriteLine("It is Friday"); 
   if(day == 6)
    Console.WriteLine("It is Saturday"); 
   if(day == 7)
    Console.WriteLine("It is Sunday"); 
   }