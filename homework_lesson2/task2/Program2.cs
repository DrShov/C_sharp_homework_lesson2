// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите любое трехзначное число: ");

string Str1 = Console.ReadLine();

Console.Write("Редактирование в объеме удаления второй цифры произведено: ");
Console.Write(Str1.Remove(1, 1));
