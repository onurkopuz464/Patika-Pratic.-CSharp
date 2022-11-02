

call_ call = new call_();
Console.Write("Lütfen bir sayı giriniz :");
int input = Convert.ToInt32(Console.ReadLine());
call.build(input);


public  class call_
{
    

    public void build(int x)
    {
       
        for (int i = 0; i <= x; i++)
        {
            for (int z = 0; z < (x-i); z++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
               
                Console.Write("*");
            }
            for (int f = 0; f < i; f++)
            {

                Console.Write("*");
            }
            Console.WriteLine();

        }
    }


}
