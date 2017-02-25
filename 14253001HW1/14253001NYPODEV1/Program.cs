//VELİ AĞIRAĞAÇ 14253001
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001NYPODEV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 1;
            int K = 1;

            Random tavsan = new Random(DateTime.Now.Second);
            Random kap = new Random();
            Console.WriteLine("BÜYÜK YARIŞ BAŞLASINNNNNN!!!!!!");
            Console.WriteLine("********************************");
            Console.WriteLine("                                ");

            int TavsanYolu = 0, KaplumbagaYolu = 0;
            //HAREKET ,ADIM KONTROL KOŞULLARI
            while (K >= 1||T>=1)
            {

                T = tavsan.Next(1, 11);
                K = kap.Next(1, 11);

                if (K>=1 && K <= 5)
                {
                    KaplumbagaYolu += 3;
                   
                }
                else if (K > 5 && K <= 7)
                {
                    KaplumbagaYolu -= 6;
                  

                    if (KaplumbagaYolu < 0)
                        KaplumbagaYolu = 1;
                   
                }
                else if (K > 7 && K <= 10)
                {
                    KaplumbagaYolu += 1;
                    
                }
                if (T >= 1 && T <= 2)
                {
                    TavsanYolu += 0;
                   
                }

                else if (T > 2 && T <= 4)
                {
                    TavsanYolu += 9;
                
                }

                else if (T > 4 && T <= 5)
                {
                    TavsanYolu -= 12;
                 
                    if (TavsanYolu < 0)
                        TavsanYolu = 1;
                 
                }

                else if (T > 5 && T <= 8)
                {
                    TavsanYolu += 1;
                  
                }

                else if (T > 8 && T <= 10)
                {
                    TavsanYolu -= 2;
     
                    if (TavsanYolu < 0)
                        TavsanYolu = 1;
         
                }

                //EKRANA YAZMA HAREKETLERİ
                if (K >= 1 && K <= 5)
                {

                    Console.Write("hızlı yürüyüş:---------------");
                    if(TavsanYolu==KaplumbagaYolu)
                        Console.WriteLine("OUCH: "+KaplumbagaYolu);
                    else
                        Console.WriteLine("K= "+KaplumbagaYolu);



                }
                else if (K > 5 && K <= 7)
                {

                    Console.Write("kayma:-----------------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + KaplumbagaYolu);
                    else
                        Console.WriteLine("K= " + KaplumbagaYolu);

                }
                else if (K > 7 && K <= 10)
                {

                    Console.Write("yavaş yürüyüş:---------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + KaplumbagaYolu);
                    else
                        Console.WriteLine("K= " + KaplumbagaYolu);

                }
                if (T >= 1 && T <= 2)
                {

                    Console.Write("uyuma:-----------------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + TavsanYolu);
                    else
                        Console.WriteLine("T= " + TavsanYolu);
                }

                else if (T > 2 && T <= 4)
                {

                    Console.Write("Büyük sıçrama:---------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + TavsanYolu);
                    else
                        Console.WriteLine("T= " + TavsanYolu);
                }

                else if (T > 4 && T <= 5)
                {
                    Console.Write("Büyük kayma: ----------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + TavsanYolu);
                    else
                        Console.WriteLine("T= " + TavsanYolu);
                }
                else if (T > 5 && T <= 8)
                {

                    Console.Write("Küçük sıçrama:---------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + TavsanYolu);
                    else
                        Console.WriteLine("T= " + TavsanYolu);
                }
                else if (T > 8 && T <= 10)
                {
                    Console.Write("küçük kayma:-----------------");
                    if (TavsanYolu == KaplumbagaYolu)
                        Console.WriteLine("OUCH: " + TavsanYolu);
                    else
                        Console.WriteLine("T= " + TavsanYolu);
                }
               //EKRANA YAZDIRMA OLAYLARI
               
                if (TavsanYolu>=70)
                {
                    Console.WriteLine("TAVŞAN KAZANDI. YUH");
                    break;
                }
                if (KaplumbagaYolu >= 70)
                {
                    Console.WriteLine("KAPLUMBAĞA KAZANDI!!! OLEY!!!!");
                    break;
                }
                 if(KaplumbagaYolu==70 && TavsanYolu == 70)
                {
                    Console.WriteLine("BERABERE:");
                    break;
                }   
            }
        }     
    }
}
