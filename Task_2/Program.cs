int number = GetNumberInput();
int digit = DigitInNumber(number);
int result = SumDigitNumber(number, digit);
Console.WriteLine(result);

int GetNumberInput()
{   
    Console.WriteLine("input number ");
    string inputNumber = Console.ReadLine();
    int number = int.Parse(inputNumber);
    return number;
}

int SumDigitNumber(int number, int DigitInNumber)
{
    int sum = 0;
    int j;
    int temp = 1;
    for (j = 1; j <= DigitInNumber; j++)
    {
        
        int plusSum = (number / temp) % 10;
        sum = sum + plusSum;
        temp *= 10;
    }
    return sum;
}

int DigitInNumber(int number)
{
    int i = 10;
    int digit = 1;
    while (number / i != 0)
    {
        i *= 10;
        digit++;
    }
    return digit;
}