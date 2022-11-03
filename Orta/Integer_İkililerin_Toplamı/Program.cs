Console.Write("ikilileri girin : ");

string STvalues = Console.ReadLine();
string[] Arrayvalues = STvalues.Split(' ');
for (int i = 0; i < Arrayvalues.Length-1; i=+i+2)
{  
        int values = Int32.Parse(Arrayvalues[i]), _values = Int32.Parse(Arrayvalues[i + 1]);      
        if (values != _values)
        {
            Console.Write(values + _values + " ");
        }
        else
        {
            Console.Write(Math.Pow((values + _values), 2) + " ");
        }   
}
