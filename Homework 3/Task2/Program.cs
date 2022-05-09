//Ввод координат первой точки (Поочерёдно A[x], A[y], A[z])
Console.Write($"Введите координату 'x' точки 'A':");
double Ax = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите координату 'y' точки 'A':");
double Ay = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите координату 'z' точки 'A':");
double Az = Convert.ToDouble(Console.ReadLine());

//Ввод координат второй точки (Поочерёдно B[x], B[y], B[z])

Console.Write($"Введите координату 'x' точки 'B':");
double Bx = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите координату 'y' точки 'B':");
double By = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите координату 'z' точки 'B':");
double Bz = Convert.ToDouble(Console.ReadLine());

//Вычисление расстояния между точками:

double linesize = Math.Sqrt (Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

//Округление результата до 2-го знака после запятой:

linesize = Math.Round(linesize, 2);

//Вывод результата вычислений:
Console.WriteLine();
Console.WriteLine($"Расстояние между точками 'A({Ax},{Ay},{Az})' и 'B({Bx},{By},{Bz})' равно {linesize}");