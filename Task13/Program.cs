// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int orig_num = num;

int CorrectIfNegative(int number)   // для изменения знака отр. числа на положительное
{
    return number < 0 ? -number : number;   // если number < 0 метод возвращает -number(т.е. положительное), иначе - ничего не делает
}
int afterCheckNum = CorrectIfNegative(num);

if (afterCheckNum < 100) Console.WriteLine($"{num} -> третьей цифры нет");
else
{
    while (afterCheckNum > 99 && afterCheckNum > 999)
    {
        afterCheckNum /= 10;
    }
    int ost = afterCheckNum % 10;
    Console.WriteLine($"{orig_num} -> {ost}");
}