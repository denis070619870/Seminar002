// Определить номер четверти плоскости, в которой находится точка с координатами X b Y неравными 0

Console.WriteLine("Введите значение координат по оси X");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координат по оси Y");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Точка в первой четверти");
}
else if (x>0 && y<0)
{
    Console.WriteLine("Точка во второй четверти");
}
else if (x<0 && y>0)
{
    Console.WriteLine("Точка в третьей четверти");
}
else if (x<0 && y<0)
{
    Console.WriteLine("Точка в первой четверти");
}
else if (x==0 && y==0)
{
    Console.WriteLine("Введите другое значение");
}