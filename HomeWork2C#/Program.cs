void ShowNumber()
{
  int num = new Random().Next(10, 99);
  int firstNum = num / 10;
  int secondNum = num % 10;
  Console.Write(num + "->");
    if (firstNum > secondNum)
    {
        Console.Write(firstNum);
    }
    else
    {
        Console.Write(secondNum);
    }
}
ShowNumber();