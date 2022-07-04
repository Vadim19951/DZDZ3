int n = InputInt("Enter number N in the Sonsole: ");

int number = 1;

int cube = 0;

while(number <= n)
{
cube =((number * number) * number);
Console.WriteLine(cube);
number++;
}




int InputInt(string output)
{
   Console.WriteLine(output);
   return Convert.ToInt32(Console.ReadLine());
}


