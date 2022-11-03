

string[] addstring = Console.ReadLine().Split(' ');
for (int j = 0; j < addstring.Length; j++)
{
    for (int i = addstring[j].Length - 1; i >= 0; i--)
    {
        Console.Write(addstring[j][i]);
    }
    Console.Write(' ');

}
