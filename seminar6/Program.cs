// Двумерные массивы и рекурсия
/*
string[,] table = new string[2,5];
table[1,2] = "слово";
for( int rows = 0; rows < 2; rows++)
{
    for( int columns = 0; columns < 5; columns ++)
    {
        Console.WriteLine($"{table[rows, columns]}");
    }
}
*/
/*
void PrintMatrix(int[,] matr)
{
 for( int rows = 0; rows < matr.GetLength(0); rows++)
{
    for( int columns = 0; columns < matr.GetLength(1); columns ++)
    {
        Console.Write($"{matr[rows, columns]} ");
    }
    Console.WriteLine();
}
}
//int [,] table = new int[3,4];
//PrintMatrix(table);
void FillMatrixRandome(int[,] matr)
{
 for( int i = 0; i < matr.GetLength(0); i++)
{
    for( int j = 0; j < matr.GetLength(1); j ++)
    {
        matr[i, j] = new Random().Next(1,10);
    }
    Console.WriteLine();
}
}
int [,] table = new int[3,4];
PrintMatrix(table);
FillMatrixRandome(table);
Console.WriteLine();
PrintMatrix(table);
*/
// семинар
/*
bool IsTriangExist(int a, int b, int c) // метод определяет существует ли треугольник со сторонами заданного размера.
{
    if(a < b + c || b < a + c || c < a + b)
    { 
        return true;
    }
    else return false;
}
*/
// написать программу, которая принимает на вход 1 массив, и возвращает его развёрнутую версию.
/*
int[] CreateRandomeArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
*/
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
/*
int[] TurnArray(int[] array) // метод разворота массива
{
    int[] tempArray = CreateRandomeArray(array.Length, 0, 1);
    for(int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    tempArray[j] = array[i];
    return tempArray;
}
int[] newArray = CreateRandomeArray(8, -10, 10);
ShowArray(newArray);
Console.WriteLine();
int[] secondArray = TurnArray(newArray);
ShowArray(secondArray);

*/

// написать программу, которая принимает натуральное число, и возвращает равное числу количество чисел фибоначи.
 int[] GetFibonacci(int num)
 {
     int[] array = new int[num];
     array[0] = 0;
     array[1] = 1;
     for (int i = 2; i < num; i ++)
     {
        array[i] = array[i-1] + array[i-2];
     }
    return array;
     }
int[] fiboArray = GetFibonacci(10);
ShowArray(fiboArray);



