﻿// Предполагается, что все числа целые и отличные друг от друга.
// Чтобы не было ругательств, как в первой задаче, решил не заморасиваться с "ReadLine"
int a, b, c, max;
a = 51;
b = 19;
c = 15;
max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Максимальное число равно {0}", max);