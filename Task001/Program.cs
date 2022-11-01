int A = -9;
int B = -3;
int max = -3;
int min = -3;

if (B > A) B = max;
else max = A;

if (B < A) B = min;
else min = A;

Console.WriteLine("max = "); 
Console.WriteLine(max);
Console.WriteLine("min = ");
Console.WriteLine(min);