// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int midlDigit = number % 100 / 10;
    int rigDigit = number % 10;
    int i = 0;
    int result = 1;
    while(i < rigDigit)
    {
        result = result * midlDigit;
        i++;

    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ввели не трехзначное число!");
}