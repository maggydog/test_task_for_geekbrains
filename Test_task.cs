// Написать программу, которая из имеющегося массива строк 
// сформирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


//Задаем длину первоначального массива
Console.WriteLine();
int n = InputNumbers("Какой длины будет первоначальный массив?");

string[] initialArray = new string[n];
FillArray(initialArray);
Console.WriteLine("Первоначальный массив:");
Console.WriteLine(OtherWayToPrintArray(initialArray));

Console.WriteLine();
int m = InputNumbers("Максимальная длина строк, из которых будем собирать новый массив: ");
string[] finalArray = GetSomeFromArray(initialArray, m);
if (finalArray.Length == 0) Console.WriteLine($"В певроначальном массиве нет элементов,длина которых меньше либо равна {m}");
else
{
    Console.WriteLine();
    Console.WriteLine("Новый массив:");
    PrintArray(finalArray);
}
Console.WriteLine();

//Функция для ввода положительного числа

int InputNumbers(string b)
{
    int a;
    Console.WriteLine(b);
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
    return a;
}

//Задаем первоначальный массив строк через ввод вручную
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент масива: ");
        array[i] = Console.ReadLine();
    }
}

// Печатаем массив

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"№{i}: {array[i]}");
    }
}

// Еще один метод печати

string OtherWayToPrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) result += $"{array[i]}";
        else result += $"{array[i]}, ";
    }
    result += " ]";
    return result;
}

// Вытащим элементы длиной <=3 из первоначального массива и поместим их в другой, новый. 
// Задачи: определяем длину нового массива, 
// инициализируем его и заполняем элементами длиной <=3, не учитывая при этом пустые строки.

int HowLongNewArray(string[] oldArray, int maxLong)
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= maxLong && !string.IsNullOrEmpty(oldArray[i])) count++;
    }
    return count;
}

string[] GetSomeFromArray(string[] oldArray, int maxLong)
{
    string[] newArray = new string[HowLongNewArray(oldArray, maxLong)];
    int j = 0;

    for (int k = 0; k < oldArray.Length; k++)
    {
        if (oldArray[k].Length <= maxLong && !string.IsNullOrEmpty(oldArray[k]))
        {
            newArray[j] = oldArray[k];
            j++;
        }
    }
    return newArray;
}
