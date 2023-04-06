Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"В какую степень необходимо возвести {number}? ");
int stepen = int.Parse(Console.ReadLine());

int i;
int result = number;
for(i = 1; i < stepen; i++)
{
    result = result * number;
}

Console.WriteLine($"{number} ^ {stepen} = {result}");