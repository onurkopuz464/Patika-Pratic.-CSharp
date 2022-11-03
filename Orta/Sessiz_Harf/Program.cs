Console.Write("Cümleyi Girin : ");
string STvalues = Console.ReadLine();
string[] Arrayvalues = STvalues.Split(' ');
char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü','A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
bool answer =false;
for (int i = 0; i < Arrayvalues.Length; i++)
{
    answer = false;
    char[] chars = Arrayvalues[i].ToCharArray();
    for (int j = 0; j < chars.Length; j++)
    {
        if (!sesli.Contains(chars[j]) && j != chars.Length - 1 && !sesli.Contains(chars[j + 1]))
        {
            answer = true;
            break;
        }
    }
    Console.Write(answer + " ");
}

