string input = Console.ReadLine(); 

string[] words = input.Split(','); 
char[] WordArray = words[0].ToCharArray();
int value = Convert.ToInt32(words[1]);

for (int i = 0; i < WordArray.Length; i++)
{
    if(i != value)
    Console.Write(WordArray[i]);

}