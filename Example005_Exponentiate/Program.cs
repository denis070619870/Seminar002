// Возведите число А в натуральную степень В используя цикл

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, которое будет являться степенью: ");
int B = int.Parse(Console.ReadLine());

int count = 0;
int result = 1;

while (count < B)
{
    result = result * A;
    count++;
}
Console.WriteLine(result);