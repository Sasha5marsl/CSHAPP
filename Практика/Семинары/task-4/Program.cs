// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99)
// {
//     int result = number % 1000 / 100;
//     System.Console.WriteLine(result);

// }
// else
// {
//     System.Console.WriteLine("В числе отсутствует третья цифра!");
// }

// Второй вариант задачи, когда выводим третью цифру с начала, а не с конца.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    while(number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("В числе отсутствует третья цифра!");
}