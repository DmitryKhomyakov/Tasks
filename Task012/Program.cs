Console.WriteLine("Введите длину массива");

int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, 40);
    Console.WriteLine(array[i]);
}