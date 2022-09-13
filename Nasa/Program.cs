using System;
using System.Collections.Generic;
using System.IO;

namespace Nasa
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat f = new feladat();
        }
        
    }

    class feladat
    {
        public feladat()
        {
            f4();
            f5();
            f6();
        }

        List<adatok> log = new List<adatok>();
        void f4()
        {
            string[] sorok = File.ReadAllLines("NASAlog.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                log.Add(new adatok(sorok[i]));
            }
        }

        void f5()
        {
            Console.WriteLine("5.feladat: Kérések száma: {0}", log.Count);
        }

        void f6()
        {
            for (int i = 0; i < log.Count; i++)
            {
                Console.WriteLine(log[i].ByteMeret());
            }


            Console.WriteLine(log[0].domain);
            Console.WriteLine(log[0].Domain);

        }
    }
                                                          
    class adatok
    {
        public string domain;
        public string datum;
        public string kep;
        public int kod;
        public int meret;
        public adatok(string sor)
        {
         
            string[] vag = sor.Split("*");
            domain = vag[0];
            datum = vag[1];
            kep = vag[2];
            string[] vag2 = vag[3].Split(" ");

            kod = Convert.ToInt32(vag2[0]);
            if(vag2[1]=="-")
            {
                meret = 0;
            }
            else
            {
                meret = Convert.ToInt32(vag2[1]);
            }
            
        }

        public int ByteMeret()
        {
            return meret;
        }

        public bool domain()
        {
            //try
            //{
             //   Console.WriteLine(Convert.ToInt32(domain[domain.Length -1]));
            //}
            //catch (Exception)
            //{

              //  throw;
            //}

            
        }
    }
}
