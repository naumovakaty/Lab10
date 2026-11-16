using System.Globalization;

string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"общее количество букв в слове: {subject.Length}");


int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade;
}
double average = (double)sum / grades.Length;
Console.WriteLine($"\n Сумма всех оценок :{sum}");
Console.WriteLine($"Средний балл: {average}");

string[] students = {"Аня", "Ярослав", "Вика"};
int count = 0;
foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}
Console.WriteLine($"\n всего учеников в массиве: {count}");

int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}
Console.WriteLine("Итоговый массив: "); 
foreach (int point in points)
{
    Console.WriteLine(point);
}


//string[] students = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string student in students)
{
    Console.WriteLine($"{number}.{student}");
    number++;
}


Console.WriteLine("Самостоятельные задания");
int[] Numbers = {5, 12, 8, 20, 3};
int Sum = 0;
Console.WriteLine("Числа в массиве: ");
foreach (int num in Numbers)
{
    Console.WriteLine(num);
    Sum += num;
}
Console.WriteLine($"Сумма всех чисел: {Sum}");

Console.WriteLine("Задача В");
string word = "программирование";
int Count = 0;
Console.WriteLine($"Слово: {word}");
foreach (char letter in word)
{
    char lowerLetter = char.ToLower(letter);
    if (lowerLetter == 'а' || lowerLetter == 'е' || lowerLetter == 'ё' || lowerLetter == 'у' || lowerLetter == 'ю' || lowerLetter == 'э' || lowerLetter == 'о' || lowerLetter == 'и' || lowerLetter == 'ы' || lowerLetter == 'я')
    {
        Count++;
    }
}
Console.WriteLine($"Количество гласных букв: {Count}");

Console.WriteLine("Введите свою фамилию:");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine("Вариант1");
int[] temperatures = { 12, 14, 0, 4, 6, 9, 13 };
//int sum = 0;
foreach (int temp in temperatures)
{
    sum += temp;
}
//double average = (double)sum / temperatures.Length;
Console.WriteLine($"Средняя температура: {average}");

Console.WriteLine("Вариант 10");
string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
int weekendCount = 0;
foreach (string day in days)
{
    if (day == "суббота" || day == "воскресенье")
    {
        weekendCount++;
    }
}
Console.WriteLine($"Количество выходных: {weekendCount}");