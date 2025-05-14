var a = Convert.ToInt32(Console.ReadLine());
var Min = int.MaxValue;
var k = 0;
for (int i = 0; i < a; i++)
{
    var d = Convert.ToInt32(Console.ReadLine());
        if (d < Min)
    {
        Min = d;
    }
    if (d > 80)
    {
        k++;
    }
}
Console.WriteLine(Min);
if (k == 1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
