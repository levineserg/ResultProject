void InputArray(string[] arrayInput, int arrayInputLength)
{
    for (int i = 0; i < arrayInputLength; i++)
    {
        Console.Write($"Введите строку {i}: ");
        arrayInput[i] = Console.ReadLine();
    }
    for (int i = 0; i < arrayInputLength; i++)
    {
        Console.Write(arrayInput[i] + "\t");
    }
    Console.WriteLine();
}
void ResultArray(string[] arrayInput, int arrayInputLength, string[] resultArray, int count)
{
    for (int i = 0; i < arrayInputLength; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            count++;
            string[] tempArray = new string[count];
            for (int j = 0; j < count - 1; j++)
            {
                tempArray[j] = resultArray[j];
                resultArray = tempArray;
            }
            resultArray[count - 1] = arrayInput[i];
            Console.Write(resultArray[count - 1] + "\t");
        }
    }
}
Console.Write("Введите длину массива: ");
int arrayInputLength = Convert.ToInt32(Console.ReadLine());
string[] arrayInput = new string[arrayInputLength];
int count = 0;
string[] resultArray = new string[count + 1];
InputArray(arrayInput, arrayInputLength);
ResultArray(arrayInput, arrayInputLength, resultArray, count);