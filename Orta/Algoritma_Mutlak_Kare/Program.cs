Console.Write("sayıları giriniz : ");
int mainvalue = 67;
string STvalues = Console.ReadLine();
string[] Arrayvalues = STvalues.Split(' ');
int buyuk = 0, kucuk = 0;

for (int i = 0; i < Arrayvalues.Length; i++)
{
    int value = Int32.Parse(Arrayvalues[i]);
    if (mainvalue > value)
    {
        kucuk += mainvalue - value;


    }
    else
    {
        buyuk = (int)Math.Pow(value - mainvalue, 2);

    }

}
Console.Write(kucuk + " " + buyuk);

