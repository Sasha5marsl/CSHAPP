// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    System.Console.WriteLine(leftDigit + "" + rightDigit);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}

// int a = 7;
// int b = 9;
// System.Console.WriteLine("Значение первой переменной: " + a + ", значение второй переменной: " + b); Конкотинация - когда метод райтлайн выдает объединение срок в одну строку.
// System.Console.WriteLine($"Значение первой переменной: {a}, значение второй переменной: {b}"); 
//f-строка позволяет более легким способом вывести на экран объединение строк со значением переменных.

if(number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int newNumber = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(newNumber);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}