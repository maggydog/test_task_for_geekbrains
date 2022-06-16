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
