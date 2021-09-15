using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VardiyaSistemi
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int OncekiVardiyaBitisi=0;
            int OncekiVardiyaBaslangic=0;
            var Silinecekler = new List<int>();

            List<List<int>> Schedule = new List<List<int>>
                                {   new List<int>(){1,2},
                                    new List<int>(){3,5},
                                    new List<int>(){4,8},
                                    new List<int>(){9,10},
                                    new List<int>(){10,12}
                                };

            int i = 0;
            int count = 0;

            foreach (var vardiya in Schedule)
            {            

                if(vardiya[0]<= OncekiVardiyaBitisi)
                {
                    vardiya[0] = OncekiVardiyaBaslangic;
                    Silinecekler.Add(i-1);
                    //Schedule.RemoveAt(i);


                }



                OncekiVardiyaBaslangic = vardiya[0];
                OncekiVardiyaBitisi = vardiya[1];

                i++;

            }

            foreach (var item in Silinecekler)
            {
               
                Schedule.RemoveAt(item-count);
                count++;
            }

            foreach (var vardiya in Schedule)
            {
                Console.WriteLine(vardiya[0].ToString() + "," + vardiya[1].ToString());
            }
            }
    }
}
