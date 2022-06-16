// Написать программу, которая из имеющегося массива строк 
// сформирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


//Задаем длину первоначального массива
Console.WriteLine("Какой длины будет первоначальный массив?");
int n;
while (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Ошибка ввода. Введите целое положительное число");

string[] initialArray = new string[n];

FillArray(initialArray);
Console.WriteLine();
Console.WriteLine("Первоначальный массив:");
Console.WriteLine(OtherWayToPrintArray(initialArray));
Console.WriteLine();
string[] finalArray = GetSomeFromArray(initialArray);
if (finalArray.Length == 0) Console.WriteLine("В певроначальном массиве нет элементов,длина которых меньше либо равна 3");
else
{
    Console.WriteLine("Новый массив:");
    PrintArray(finalArray);
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

// Напечатаем массив

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
        if (i == array.Length - 1) result += $"{array[i],5}";
        else result += $"{array[i]}, ";
    }
    result += " ]";
    return result;
}

// Вытащим из этого массива другой, с длиной строк <=3. 
// Тут сначала вытаскиваем длинну будущего массива, 
// потом инициализируем его и заполняем элементами <=3.

int HowLongNewArray(string[] oldArray)
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3 && !string.IsNullOrEmpty(oldArray[i])) count++;
    }
    return count;
}

string[] GetSomeFromArray(string[] oldArray)
{
    string[] newArray = new string[HowLongNewArray(oldArray)];
    int j = 0;

    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3 && !string.IsNullOrEmpty(oldArray[i]))
        {
            newArray[j] = oldArray[i];
            j++;
        }
    }
    return newArray;
}
