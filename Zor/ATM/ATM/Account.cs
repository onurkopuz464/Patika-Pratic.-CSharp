using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{


    public  class Account
    {

        public static List<Account_values> accounts = new List<Account_values>();
        public static int index = 0;
 

        public static void AllAccount()
        {
            accounts.Add(new Account_values { TC = 1, isim = "Onur", Soyisim = "Kopuz", Bakiye = 30000, Borc = 1500, Pass = 12345 });
            accounts.Add(new Account_values { TC = 2, isim = "Sinem", Soyisim = "Erdogan", Bakiye = 20000, Borc = 4500, Pass = 12345 });
            accounts.Add(new Account_values { TC = 3, isim = "Büşra", Soyisim = "Üce", Bakiye = 10000, Borc = 3500, Pass = 12345 });
            accounts.Add(new Account_values { TC = 4, isim = "Fatih", Soyisim = "Erdogan", Bakiye = 70000, Borc = 2500, Pass = 12345 });
            accounts.Add(new Account_values { TC = 5, isim = "Şükran", Soyisim = "Kopuz", Bakiye = 1000000, Borc = 5500, Pass = 12345 });
        }
        public static bool check_Acc(int x)
        {
            if (null!=accounts.Find(a => a.TC == x))
            {
                index = accounts.FindIndex(a => a.TC == x);
                var Acc = accounts[index];
                return true;
            }
            else
                return false;

        }

    }




    public class Account_values
    {
        public int TC { get; set; }
        public float Bakiye { get; set; }
        public float Borc { get; set; }
        public int Pass { get; set; }
        public string isim { get; set; }
        public string Soyisim { get; set; }


    }
}
