// Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите любое число: ");

string Str1 = Console.ReadLine();
int a = Str1.Length;

if (3 > a)
{
    Console.WriteLine("В предложенном числе третья цифра отсутствует!");
}
else
{
    Console.Write(Str1[2]);
    Console.Write("- третья цифра предложенного числа");
}
