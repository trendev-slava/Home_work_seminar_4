Console.WriteLine("задайте размер массива ");
int sizeArray = int.Parse(Console.ReadLine());
Console.WriteLine("минимальное значение массива");
int minValueArray = int.Parse(Console.ReadLine());
Console.WriteLine("максимальное значение массива ");
int maxValueArray = int.Parse(Console.ReadLine());
Console.WriteLine("");

int[] numbers = new int[sizeArray];
numbers[0] = minValueArray;
numbers[sizeArray - 1] = maxValueArray;

int index;
for (index = 1; index < sizeArray - 1; index++)
{
    numbers[index] = new Random().Next(minValueArray, maxValueArray);
}

int index1;
for (index1 = 0; index1 < numbers.Length - 1; index1++)
{

    int index2;
    for (index2 = index1 + 1; index2 < numbers.Length; index2++)
    {
        if (numbers[index2] < numbers[index1])
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}

void Print(int[] array)
{
    int i;
    for (i = 0; i < sizeArray; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Print(numbers);