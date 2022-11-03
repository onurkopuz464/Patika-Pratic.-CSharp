sekil sekil = new sekil();
Console.Write("Şekili seçiniz. Kare(1) Ucgen(2) Dıkdortgen(3) Daire(4)    : ");
int type = Convert.ToInt32(Console.ReadLine());
switch (type)
{
    case 1:      
        sekil.Kare();
        break;
    case 2:
        sekil.Ucgen();
        break;
    case 3:

        sekil.Dikdortgen();
        break;
    case 4:
        sekil.Daire();
        break;
}



public class sekil
{
    public void Kare()
    {
        Console.Write("Kenar uzunluğunu giriniz : ");
        int x = Int32.Parse(Console.ReadLine());
        Console.WriteLine( x*x);
    }
    public void Dikdortgen()
    {
        Console.Write("Kenar uzun kenar uzunluğunu giriniz : ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Kenar kısa kenar uzunluğunu giriniz : ");
        int y = Int32.Parse(Console.ReadLine());
        Console.WriteLine(x * y);
    }
    public void Daire()
    {
        Console.Write("Çevre uzunluğunu giriniz : ");
        int x = Int32.Parse(Console.ReadLine());
        Console.WriteLine((x *x) *3.14);
    }
    public void Ucgen()
    {
        Console.Write("Taban uzunluğunu giriniz : ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Yükseklik giriniz : ");
        int y = Int32.Parse(Console.ReadLine());
        Console.WriteLine((x * y)/2);
    }

}
