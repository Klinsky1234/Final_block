/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма.
Примеры:
Примеры массивов и результаты выводов
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма.
Примеры:
Примеры массивов и результаты выводов
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
[""1234", "1", "-2", "computer science", "tes", "Test1"] -> [ "1"  "-2"  "tes" ]
["Russia", "Denmark", "Kazan"] -> [] */

string[] arr = new string[6] { "1234", "1", "-2", "computer science", "tes", "Test1" };
string[] arr1 = new string[arr.Length];
void Cycle(string[] arr, string[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            arr1[count] = arr[i];
        count++;
    }
}
void Print(string[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)

        Console.Write($"{arr2[i]} ");
}
Console.WriteLine();
Console.Write($"Результат: ");
Cycle(arr, arr1);
Print(arr1);