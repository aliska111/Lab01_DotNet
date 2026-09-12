// int age = 18;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

string firstName = "Алиса";
string lastName = "Маменко";
string group = "ИСП-243";
int birthYear = 2008;
double gpa = 3.5;
bool hasScholarship = false;
int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");
Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");