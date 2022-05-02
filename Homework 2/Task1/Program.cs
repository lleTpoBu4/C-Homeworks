
int GetMax ()
{
int number = new Random().Next(10,100);
int a = number / 10;
int b = number % 10;
int max = a;
if (max < b) max = b;
return max;
}
Console.WriteLine(GetMax());