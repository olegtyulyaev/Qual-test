
// Написать программу,  которая из имеющегося массива строк формирует массив из строк, длинна которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();

string[] firstArray = { "hello", "2", "word", ":-)", "123", "156", "computer scence", "Russia", "Denmark", "Kaz" };

string str = string.Empty;

//провекрка элементов массива до последнего на соотвествие условию для добавления в переменную str
for (int i = 0; i < firstArray.Length - 1; i++)
{
    if (firstArray[i].Length <= 3) str = str + firstArray[i] + ",";
}
// Проверяем последнего элемента  firstArray[] на соотвествие условию для добавления в переменную str
if (firstArray[firstArray.Length - 1].Length <= 3) str = str + firstArray[firstArray.Length - 1];

// Делим строку str сплитом и записываем в массив secondArr[]
string[] secondArr = str.Split(",");

//Вывод итогового массива secondArr[] в консоль
Console.Write("[");
for (int i = 0; i < secondArr.Length - 1; i++)
{
    Console.Write(secondArr[i] + ", ");
}
Console.WriteLine(secondArr[secondArr.Length - 1] + "]");
