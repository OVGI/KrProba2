Console.WriteLine("Введите массив строк через пробел: ");
string[] firstArray = Console.ReadLine()!.Split(' ');
string[] secondArray = new string[firstArray.Length];


void SecondArrayReceive(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
SecondArrayReceive(firstArray, secondArray);
PrintArray(secondArray);