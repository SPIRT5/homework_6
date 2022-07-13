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

double b1 = GetNumber("Введите координату b1: "); //2
double k1 = GetNumber("Введите координату k1: "); //5
double b2 = GetNumber("Введите координату b2: "); //4
double k2 = GetNumber("Введите координату k2: "); //9

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых: " + x + "; " + y);


