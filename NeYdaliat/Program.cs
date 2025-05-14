var b = Convert.ToInt32(Console.ReadLine());
var k = 0;
var sum = 0;
while (b != 0)
{
    k++;
    if (b > 0 && b < 256 && b % 2 == 0)
    {
        sum += b;
    }
    b = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine(k);
Console.WriteLine(sum);