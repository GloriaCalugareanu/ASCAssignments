using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar in baza 2");
            string number2;

            number2 = Console.ReadLine();
            number2 = number2.TrimStart('0');


            Console.WriteLine("Introduceti baza in care convertiti");
            int baza;
            baza = int.Parse(Console.ReadLine());

            Dictionary<string, string> base16 = new Dictionary<string, string>();

            base16.Add("0000", "0");
            base16.Add("0001", "1");
            base16.Add("0010", "2");
            base16.Add("0011", "3");

            base16.Add("0100", "4");
            base16.Add("0101", "5");
            base16.Add("0110", "6");
            base16.Add("0111", "7");

            base16.Add("1000", "8");
            base16.Add("1001", "9");
            base16.Add("1010", "A");
            base16.Add("1011", "B");

            base16.Add("1100", "C");
            base16.Add("1101", "D");
            base16.Add("1110", "E");
            base16.Add("1111", "F");

            Dictionary<string, string> base8 = new Dictionary<string, string>();
            base8.Add("000", "0");
            base8.Add("001", "1");
            base8.Add("010", "2");
            base8.Add("011", "3");

            base8.Add("100", "4");
            base8.Add("101", "5");
            base8.Add("110", "6");
            base8.Add("111", "7");


            Dictionary<string, string> base4 = new Dictionary<string, string>();

            base4.Add("000", "0");
            base4.Add("001", "1");
            base4.Add("010", "2");
            base4.Add("011", "3");


            //Console.WriteLine(base16["1110"]);
            //foreach (var item in base16.Keys)
            // {
            //   Console.WriteLine($"{key}-{base16[key]}");
            //  }

            int nrCifre = 0;
            switch(baza)
            {
                case 4:
                    nrCifre = 2;
                    break;
                case 8:
                    nrCifre = 3;
                    break;
                case 16:
                    nrCifre = 4;
                    break;
                default:
                    Console.WriteLine("Baza tinta nu este corecta");
                    break;


            }
            int lungimeaNumarB2;
            lungimeaNumarB2 = number2.Length;
            int nrZerouriDeAdaugat=0;
            if(lungimeaNumarB2%nrCifre>0)
            {
                nrZerouriDeAdaugat = nrCifre - lungimeaNumarB2 % nrCifre;
            }
            number2 = number2.PadLeft(nrZerouriDeAdaugat + lungimeaNumarB2, '0');

            StringBuilder sb = new StringBuilder();
            int i = 0;
            string key;
            while(i<number2.Length/nrCifre)
            {
                key=number2.Substring(i * nrCifre, nrCifre);
                switch(baza)
                {
                    case 4:
                        sb.Append(base4[key]);
                        break;
                    case 8:
                        sb.Append(base8[key]);
                        break;
                    case 16:
                        sb.Append(base16[key]);
                        break;
                }
                i++;
            }
            string result = sb.ToString();
            result = result.TrimStart('0');
            Console.Write(result);
        }
    }
}
