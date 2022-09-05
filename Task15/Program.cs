// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру дня недели [1...7]: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsWeekEnd(int dayOfWeek)
{
    if (dayOfWeek == 6 || dayOfWeek == 7) return true;
    else return false;
}

if (num > 0 && num < 8)
{
    bool result = IsWeekEnd(num);
    if(result) Console.WriteLine($"{num} -> да, это выходной");
    else Console.WriteLine($"{num} -> нет, это не выходной");
}
else Console.WriteLine("Ошибка ввода. Введите число в диапазоне [1...7].");