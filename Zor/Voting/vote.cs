using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace patika
{
    public static class vote
    {
        static List<resultCatalog> list = new List<resultCatalog>();
        public static void start()
        {
            list.Add(new resultCatalog { Id = "Asm", point = 40 });
            list.Add(new resultCatalog { Id = "C", point = 22 });
            list.Add(new resultCatalog { Id = "Python", point = 18 });
            list.Add(new resultCatalog { Id = "React", point = 10 });
        }
        
      

        public static void InputVote(int x)
        {
            int index = 0;
            
            

            switch (x)
            {
                case 1:
                    index = list.FindIndex(x => x.Id =="Asm");
                    list[index].point++;
                    break;
                case 2:
                    index = list.FindIndex(x => x.Id == "C");
                    list[index].point++;
                    break;
                case 3:
                    index = list.FindIndex(x => x.Id == "Python"); ;
                    list[index].point++;
                    break;
                case 4:
                    index = list.FindIndex(x => x.Id == "React");
                    list[index].point++;
                    break;

            }
        }
        public static void result()
        {
           
            Console.Clear();
            Console.WriteLine("******Sonuçlar******");

            foreach (var item in list)
            {
               
                Console.WriteLine(item.Id+" Dilinin Aldığı Oy Sayısı: "+item.point);
                
            }
            Console.WriteLine("*************");
            foreach (var item in list)
            {
                Console.WriteLine(item.Id + " Dilinin Aldığı Oy Yüzdesi: " + HelperResult(item.point));
            }
            Console.WriteLine("Devam Etmek İçin Tuşa Basınız");
            Console.ReadLine();



        }
        public static float HelperResult(int x)
        {
           
            float values = list[0].point + list[1].point + list[2].point + list[3].point;

            return Convert.ToSingle(x) * values / 100;


            

        }
        public static void clearVote()
        {
            foreach (var item in list)
            {
                item.point = 0;
            }
            Console.WriteLine("Tüm Oylar Sıfırlandı.. Devam Etmek için Bir tuşa Basınız.");
            Console.ReadLine();
        }
        public  class resultCatalog
        {
            public string Id { get; set; }
            public int point { get; set; }
           
        }


    }
}
