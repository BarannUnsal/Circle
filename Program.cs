double cap;
double kalınlık = 0.4;
char sembol = '*';
do
{
    Console.Write("Çapını girin: ");
    if (!double.TryParse(Console.ReadLine(), out cap) || kalınlık <= 0)
    {
        Console.WriteLine("Negatif rakam olamaz");
    }
}
while (cap <= 0);
Console.WriteLine();
double rIn = cap - kalınlık, rOut = cap + kalınlık;
for (double y = cap; y >= -cap; --y)
{
    for (double x = -cap; x < rOut; x += 0.5)
    {
        double deger = x * x + y * y;
        if (deger >= rIn * rIn && deger <= rOut * rOut)
        {
            Console.Write(sembol);
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
Console.ReadLine();
