int A = 2;
int B = 10;
int max = B;
int min = B;

if (B > A) max = B; 
    else  min = B;
if (A > B) max = A;
    else  min = A;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);