using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayının_Tek_mi_Çift_mi_Olduğunu_Bulan_C_Uygulumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if ((sayi % 2) == 0)
            {
                Console.Write("Sayı Çifttir");
            }
            else Console.Write("Sayı Tektir");
            Console.ReadKey();
            }
        
                
        }

    }

