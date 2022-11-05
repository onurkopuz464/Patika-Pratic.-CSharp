using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{

    public static class Gun_Sonu
    {
        public static List<string> History = new List<string>();

        public static void logger(string x)
        {
            DateTime time = DateTime.Now;
            History.Add(time + " " + x);

            foreach (var item in History)
            {
                var abc = item;
            }
        }
        public static void extract()
        {
            string File = @"C:\atmlogger.txt";
            FileStream access = new FileStream(File, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter create = new StreamWriter(access);
            foreach (var item in History)
            {
                create.WriteLine(item);
            }
            create.Flush();
            create.Close();
            access.Close();
        }

    }
}
