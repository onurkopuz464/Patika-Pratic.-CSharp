Console.Write("Cümleyi Girin : ");
string STvalues = Console.ReadLine();
string[] Arrayvalues = STvalues.Split(' ');

for (int i = 0; i < Arrayvalues.Length; i++)
{
    char[] chars = Arrayvalues[i].ToCharArray();
    char history = chars[0];
    chars[0] = chars[chars.Length-1]; 
    chars[chars.Length-1] = history;

    foreach (var item in chars)
           Console.Write(item);

    Console.Write(" ");

}
