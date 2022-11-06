Console.Write("day");
int day = Convert.ToInt32(Console.ReadLine());

while (day > 0 && day < 8) 
{
    if (day < 6)
    {
        Console.WriteLine("Будний день ");
        day = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Выходной день ");
        day = Convert.ToInt32(Console.ReadLine());   
    }
 
}

