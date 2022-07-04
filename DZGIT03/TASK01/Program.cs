int n1 = InputInt("Введите число: ");

int n2 = 0;
int digit = 0;
int a = n1;
int count = 0;

 while(count < 5)
{
    digit = n1 % 10;
    n1 = n1 / 10;
    n2 = (n2 * 10) + digit;
    count++;
}

if(a == n2)
{
    Console.WriteLine("Palendrom");
}
else
{
    Console.WriteLine("N0 Palendrom");
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
