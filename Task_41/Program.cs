/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/


Console.Write("Введите колличество чисел:");
int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} число:");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Вы ввели: {string.Join(", " , array)}");
int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        quantity = quantity + 1;
    }
}
Console.WriteLine($"Колличество чисел больше нуля: {quantity}");
