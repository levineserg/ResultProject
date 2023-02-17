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