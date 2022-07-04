int x1 = InputInt("Введите координаты точки x1: ");
int x2 = InputInt("Введите координаты точки x2: ");
int y1 = InputInt("Введите координаты точки y1: ");
int y2 = InputInt("Введите координаты точки y2: ");

int z1 = 0;
int z2 = 0;

double xyz = Math.Sqrt((x1 * x2) + (y1 * y2) + (z1 * z2));

Console.WriteLine(xyz);


int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

