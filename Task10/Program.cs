// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int CorrectIfNegative(int number)   // для изменения знака отр. числа на положительное
{
    return number < 0 ? -number : number;   // если number < 0 метод возвращает -number(т.е. положительное), иначе - число без изменений
}

int ToParseToTens(int numToParseToTens) // функция получения 2-х значного числа из 3-х значного
{
    return numToParseToTens /= 10;
}

int afterCheckNum = CorrectIfNegative(num); // результат корректировки, если число на входе отрицательное

if (afterCheckNum > 99 && afterCheckNum < 1000)  // если число 3-х значное отправляем его в метод получения 2-х значного числа и вычисляем 2-ю цифру
{
    int tensNumber = ToParseToTens(afterCheckNum);  // получаем 2-х значное число
    int ost = tensNumber % 10;                      // находим 2-ю цифру
    Console.WriteLine($"{num} -> {ost}");           // вывод первоначального числа и 2-й цифры
}
else Console.WriteLine("Ошибка ввода. Введите трехзначное число.");      // если число не 3-х значное выводим msg "ошибка ввода"
