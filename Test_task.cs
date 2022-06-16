// Написать программу, которая из имеющегося массива строк 
// сформирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


//Задаем длину первоначального массива
Console.WriteLine("Какой длины будет первоначальный массив?");
int n;
while (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Ошибка ввода. Введите целое положительное число");
string[] initialArray = new string[n];

FillArray(initialArray);
Console.WriteLine("Первоначальный массив:");
PrintArray(initialArray);

Console.WriteLine("Новый массив:");
string[] finalArray = GetSomeFromArray(initialArray);
PrintArray(finalArray);


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