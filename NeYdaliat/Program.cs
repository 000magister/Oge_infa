var a = Convert.ToInt32(Console.ReadLine());
var sum = 0.0;
var k = 0.0;
while (a != 0)
{
    if (a % 8 == 0)
    {
        sum += a;
        k++;
    }
    a = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Math.Round(sum / k, 1));
if (k == 0)
{
    Console.WriteLine("No");
}