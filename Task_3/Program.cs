int[] optionArray = OptionArray();
int[] arrayNumber = new int[optionArray[0]];
FillingArray(arrayNumber);
SortArray(arrayNumber);
PrintArray(arrayNumber);


int[] OptionArray()
{
    int[] optionArray = { 0, 0, 0 };
    Console.WriteLine("size array ");
    optionArray[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("min value array ");
    optionArray[1] = int.Parse(Console.ReadLine());
    Console.WriteLine("max value array ");
    optionArray[2] = int.Parse(Console.ReadLine());
    return optionArray;
}

int[] FillingArray(int[] arrayNumber)
{
    arrayNumber[0] = optionArray[1];
    arrayNumber[optionArray[0] - 1] = optionArray[2];
    int index;
    for (index = 1; index < optionArray[0] - 1; index++)
    {
        arrayNumber[index] = new Random().Next(optionArray[1], optionArray[2] + 1);
    }
    return arrayNumber;
}

void PrintArray(int[] arrayNumber)
{
    int index;
    for (index = 0; index < optionArray[0]; index++)
    {
        Console.WriteLine(arrayNumber[index]);
    }
}

int[] SortArray(int[] arrayNumber)
{
    int index1;
    for (index1 = 0; index1 < arrayNumber.Length - 1; index1++)
    {
        int index2;
        for (index2 = index1 + 1; index2 < arrayNumber.Length; index2++)
        {
            if (arrayNumber[index2] < arrayNumber[index1])
            {
                int temp = arrayNumber[index1];
                arrayNumber[index1] = arrayNumber[index2];
                arrayNumber[index2] = temp;
            }
        }
    }
    return arrayNumber;
}