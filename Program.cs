string subject = "Программирование";
foreach (char letter in subject) {
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв {subject.Length}");

int[] grades = {4, 5, 3, 5, 4};
foreach (int grade in grades) {
    Console.WriteLine(grade);
}
Console.WriteLine($"Средний балл {grades.Length}");