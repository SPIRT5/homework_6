Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число, введите число!";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int length = 8;
int[] numberArray = new int[length];
int result = 0;

for (int i = 0; i < length; i++)
{
    numberArray[i] = GetNumber("Введите число: ");
    if (numberArray[i] > 0) 
    {
        result++;
    }
}

for (int i = 0; i < length; i++)
{
    Console.Write(numberArray[i] + ", ");
}

Console.WriteLine();
Console.WriteLine("Кол-во чисел больше 0 в массиве: " + result);
