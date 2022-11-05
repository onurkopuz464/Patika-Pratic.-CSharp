using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Hesaplamalar
    {
        
        public static List<Banknot> banknots = new List<Banknot>();
        
        public static void ParaBol(int CekilcekPara)
        {
            banknots.Add(new Banknot());
            

            if (CekilcekPara >= 200)
            {
                banknots[0]._200 = CekilcekPara / 200;
                CekilcekPara = CekilcekPara % 200;
            }

            if(CekilcekPara >= 100 )
            {
                banknots[0]._100 = CekilcekPara / 100;
                CekilcekPara = CekilcekPara % 100;
            }
            if (CekilcekPara >= 50)
            {
                banknots[0]._50 = CekilcekPara / 50;
                CekilcekPara = CekilcekPara % 50;
            }
            if (CekilcekPara >= 20)
            {
                banknots[0]._20 = CekilcekPara / 20;
                CekilcekPara = CekilcekPara % 20;
            }
            if (CekilcekPara >= 10)
            {
                banknots[0]._10 = CekilcekPara / 10;
                CekilcekPara = CekilcekPara % 100;
            }
            if (CekilcekPara >= 5)
            {
                banknots[0]._5 = CekilcekPara / 5;
                CekilcekPara = CekilcekPara % 5;
            }
            if (CekilcekPara >= 1)
            {
                banknots[0]._1 = CekilcekPara / 1;
                CekilcekPara = CekilcekPara % 1;
            }
            

        }
        public static void KrediOde(float x)
        {
            Account.accounts[Account.index].Bakiye-= x;
            Gun_Sonu.logger(Account.accounts[Account.index].isim + " -Kredi Ödemesi :" + x + " TL");

        }
        public static void Transfer(int x, float y)
        {
            Account.accounts[x].Bakiye += y;
            Account.accounts[Account.index].Bakiye -= y;
            Gun_Sonu.logger(Account.accounts[Account.index].isim + " -Para Transferi  : - Alıcı :"+ Account.accounts[x].isim +y+ " TL");

        }
    }


    public class Banknot
    {
        public float _200 { get; set; }
        public float _100 { get; set; }
        public float _50 { get; set; }
        public float _20 { get; set; }
        public float _10 { get; set; }
        public float _5 { get; set; }
        public float _1 { get; set; }
        



    }
}
