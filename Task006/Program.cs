int Func(int number, int number1)
{
    while (number > 999)
    {
        number1 = number / 10;
        number = number1;
    }
    return (number % 10);
}

int number2 = 31;
int number3 = 0;

if (number2 > 99)
{
    int number4 = Func(number2, number3);
    Console.WriteLine("Третья цифра в числе = " + number4);
}

else
{
    Console.WriteLine("В числе меньше 3-х цифр!");
}
