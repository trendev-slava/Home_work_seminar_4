Console.WriteLine("Введите ПОЛОЖИТЕЛЬНОЕ число: ");
int number = int.Parse(Console.ReadLine());

// определяю количество знаков в числе
int variable = number;
int count = 1;
int i = 1;

while(variable / 10 != 0)
{
    variable = variable / 10;
    count++;
    i = i * 10;
}
//инициализирую и заполняю массив

int[] array= new int[count];
int index = 0;
while (index < array.Length)
{
    array[index] =number / i % 10;
    i = i / 10;
    index++;
}

int j;
int res = 0;
for(j=0;j<array.Length;j++)
{
    res = res + array[j];
}

Console.WriteLine($"сумма = {res}");