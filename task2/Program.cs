// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда  5 -> Пятница
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.Write("понедельник");
}
if(number == 2)
{
    Console.Write("вторник");
}
if(number == 3)
{
    Console.Write("среда");
}
if(number == 4)
{
    Console.Write("четверг");
}
if(number == 5)
{
    Console.Write("пятница");
}