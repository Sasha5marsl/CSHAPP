double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
// Для вывода значения создадим переменную, в которой сохраним результат и выведем значение результата на экран.
double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);