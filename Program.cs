string subject = "Програмирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"общее количество букв в слове: {subject.Length}");


int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades) {
    Console.WriteLine(grade);
sum += grades;
}
double average = (double)sum / grades.Length;
Console.WriteLine($"\n Сумма всех оценок :{sum}");
Console.WriteLine($"Средний балл: {average}");