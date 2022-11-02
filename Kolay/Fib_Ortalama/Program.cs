Console.Write("Sayi Giriniz : ");
int value = Convert.ToInt32(Console.ReadLine());
Fib_(value);


static void Fib_(int lenght)
{
    int x = 0, y = 1, z = 0; double ort = 1;

    Console.Write("{0} {1}", x, y);

    for (int i = 2; i < lenght; i++)
    {
        z = x + y;
        Console.Write(" {0}", z);
        x = y; y = z;
        ort += z;
    }

    Console.WriteLine();
    
    Console.WriteLine("Ortalama : "+(ort/lenght));
}

