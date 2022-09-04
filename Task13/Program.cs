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
    return number < 0 ? -number : number;   // если number < 0 метод возвращает -number(т.е. положительное), иначе - число без изменений
}

int ToParseHundreds(int numToParseHundreds) // функция получения 3-х значного числа
{
    while (numToParseHundreds > 999) // цикл выполняется, если число > 3-х значного, если сразу 3-х эначное - минует цикл
    {
        numToParseHundreds /= 10;   //циклическим делением на 10 получаем 3-х значное число
    }
    return numToParseHundreds;
}

int afterCheckNum = CorrectIfNegative(num); // результат корректировки, если число на входе отрицательное

if (afterCheckNum > 99)  // если число 3-х значное и больше отправляем его в метод получения 3-х значного числа и вычисляем 3-ю цифру
{
    int hundredsNumber = ToParseHundreds(afterCheckNum);    // получаем 3-х значное число
    int ost = hundredsNumber % 10;                          // находим 3-ю цифру
    Console.WriteLine($"{orig_num} -> {ost}");              // вывод первоначального числа и 3-й цифры
}
else Console.WriteLine($"{num} -> третьей цифры нет");      // если число не 3-х значное выводим msg "нет третьей цифры"
