using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static patika.vote;

namespace patika
{
    public class Account
    {
        List<_Account> accounts = new List<_Account>();
        
        public Account()
        {
           

            accounts.Add(new _Account { UserName = "User_1", Pass = "Pass_1" });
            accounts.Add(new _Account { UserName = "User_2", Pass = "Pass_2" });
            accounts.Add(new _Account { UserName = "User_3", Pass = "Pass_3" });
            accounts.Add(new _Account { UserName = "User_4", Pass = "Pass_4" });

        }
        public void Register()
        {
            Console.Clear();
            Console.WriteLine("Hesap Oluşturma Ekranına Hoşgeldiniz");
            Console.Write("Oluşturacağınız Kullanıcı Adı : ");
            string x = Console.ReadLine();
            Console.Write("Oluşturacağınız Şifre : ");
            string y = Console.ReadLine();
            accounts.Add(new _Account { UserName = x, Pass = y });
            Console.Write("Hesap Oluşturuldu! Giriş Paneline Aktarılıyorsunuz");
            CheckUser();
        }
        public void CheckUser()
        {
            Console.Clear();
            Console.Write("");
            Console.Write("Kullanıcı Adınızı Girin : ");
            string z = Console.ReadLine();


            if (0 == accounts.FindAll(x => x.UserName == z).Count)
            {
                Console.WriteLine("Kullanıcı Adı Sistemde Bulunamadı Yeni Hesap Açmak istermisiniz (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                    Register();
                else
                {
                    CheckUser();
                }
            }
            else
            {
                Console.WriteLine("Lütfen Oy Vereceğiniz Dili Seçiniz..");
                Console.Write("Asm:(1) C:(2) Python:(3) React:(4)      :");
                vote.InputVote(Int32.Parse(Console.ReadLine()));

            }
        }
    }
    class _Account
    {
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string vote { get; set; }

    }

}
