using BarcodeLib;
using System.Diagnostics;
using System.Drawing;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Barkodu giriniz      : ");

        Barcode barcode = Barcode_.Barcode_Generator(Console.ReadLine());
        Console.WriteLine(Barcode_.Read(barcode));
        System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Barkot.PNG");


    }
}

class Barcode_
{
    static TYPE type_ = TYPE.PHARMACODE;
    public static Barcode Barcode_Generator(string x)
    {
        Barcode barcode = new Barcode();
        barcode.Encode(type_, x);
        barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Barkot.png", BarcodeLib.SaveTypes.PNG);
        Console.WriteLine("barkod oluştutuldu");
        return barcode;
   }
    public static string Read(Barcode barcode)
    {
        return barcode.RawData;
    }
}

