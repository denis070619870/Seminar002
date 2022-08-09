// Вывести квадраты чисел от 1 до N

Console.WriteLine("Введите число до которого будут посчитаны квадраты, начиная от 1: ");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count <= N)
{
    Console.WriteLine(count * count);
    count = count + 1;    
}


