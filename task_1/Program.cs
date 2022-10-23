
//Задача 41: Пользователь вводит с клавиатуры M чисел.
 //Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, -567, 89, 223-> 3

Console.Write("Введите элементы через пробел: ");
int[] number = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < number.Length; i++)
{
    if (number[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");





