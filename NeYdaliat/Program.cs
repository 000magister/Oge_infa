var a = Convert.ToInt32(Console.ReadLine());
var Max = int.MinValue;
var k = 0;
for (int i = 0; i < a; i++)
{
    var d = Convert.ToInt32(Console.ReadLine());
        if (d > Max)
    {
        Max = d;
    }
    if (d < 30)
    {
        k++;
    }
}
Console.WriteLine(Max);
if (k == 1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
