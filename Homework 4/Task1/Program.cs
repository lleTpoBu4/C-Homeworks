Console.WriteLine("Введите любое целое число:");
double A = Convert.ToDouble(Console.ReadLine()); //Ввод числа
A = Math.Round(A); // округление до целого (а то мало ли...)
//Написание метода (Найти сумму арифметической прогрессии от 1 до n):
//Для n > 0
double SumArProgPos(double n)
{
    double result = (1 + n) / 2 * n;
    return result;
}

//Для n < 0
double SumArProgCons(double n)
{   double result = (1+n)/2*(-n+2);
    return result;
}


//Вывод результата вычислений:
if (A > 0)
Console.WriteLine($"Cумма чисел от 1 до {A} равна: {SumArProgPos(A)}");
else
Console.WriteLine($"Cумма чисел от 1 до {A} равна: {SumArProgCons(A)}");