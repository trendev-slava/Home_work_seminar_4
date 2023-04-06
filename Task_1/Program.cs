Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine());
Console.WriteLine($"В какую степень необходимо возвести {number}? ");
double stepen = double.Parse(Console.ReadLine());

int i;
double result = number;

if (stepen == 0)
{
    result = 1;
}

else if (stepen > 0)
{
    for (i = 1; i < stepen; i++)
    {
        result = result * number;
    }
}
else
{
    stepen = stepen * -1;
    for (i = 1; i < stepen; i++)
    {
        result = result * number;
    }
    result = 1 / result;
}
Console.WriteLine($"{number} ^ {stepen} = {result}");