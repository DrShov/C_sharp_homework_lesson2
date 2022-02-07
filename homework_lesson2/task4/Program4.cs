// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.WriteLine("Введите интресующий Вас день в формате 'год, месяц, день': ");

string str1 = Console.ReadLine();

DateOnly SomeDate = DateOnly.Parse(str1);

if (SomeDate.DayOfWeek == DayOfWeek.Sunday || SomeDate.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine("Ура! Выходной! Отдыхайте!");
}
else
{
    Console.WriteLine("Как жаль! Будний день! Идите работать!");
}


