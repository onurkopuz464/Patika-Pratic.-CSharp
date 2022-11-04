using patika;
using System.Collections.Generic;

Account account = new Account();
vote.start();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Black;

while (true)
{
    Console.Clear();
    Console.WriteLine("Oy Verme Uygulamasına Hoş Geldiniz.");
    Console.WriteLine("Oy girişi için (1)");
    Console.WriteLine("Sonuçlar için (2)");
    Console.WriteLine("Oyları Sıfırla (3)");  
    Console.WriteLine("Çıkmak için (4)");
    int answer = Int32.Parse(Console.ReadLine());
    switch (answer)
    {
        case 1:
            account.CheckUser();
            break;
        case 2:
            vote.result();
            break;
        case 3:
            vote.clearVote();
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
}
