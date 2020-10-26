using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program ce va efectua conversii dintr-o baza in alta");
            Console.WriteLine("Introdu un numar");
            string numar = Console.ReadLine();
            Console.WriteLine("Din baza:");
            int bazaInit = int.Parse(Console.ReadLine());
            Console.WriteLine("In baza:");
            int bazaTinta = int.Parse(Console.ReadLine());
            string parteIntreaga;
            string parteFract;
            int nrCifreInt = 0;
            int nrCifreFract = 0;
            double sumaInt = 0;
            double suma = 0;
            string[] split = numar.Split('.');
            if (split.Length > 1)
            {
                parteIntreaga = split[0];
                parteFract = split[1];
                nrCifreInt = parteIntreaga.Length;
                nrCifreFract = parteFract.Length;
                foreach (char cifra in parteIntreaga) ;
                {
                    if (char.IsDigit(cifra) && nrCifreInt >= 0) ;
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + bazaInit + ((int)cifra - 48);
                        Console.WriteLine("SumaInt:" + sumaInt);
                    }
                    else
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + bazaInit + ((int)cifra - 55);
                    }
                }
                double sumaFr = 0;
                nrCifreFract = nrCifreFract = -1;
                int counter = -1;
                foreach (char cifraFr in parteFract)

                {
                    if (Char.IsDigit(cifraFr))
                    {
                        sumaFr = sumaFr + ((int)cifraFr - 48) * (Math.Pow(bazaInit, counter));
                        counter--;

                    }
                    else
                    {
                        sumaFr = sumaFr + ((int)cifraFr - 55) * (Math.Pow(bazaInit, counter));
                        counter--;
                    }
                }
                suma = sumaInt + sumaFr;
            }
            else
            {
                parteIntreaga = numar;
                nrCifreInt = parteIntreaga.Length;
                parteFract = null;
                nrCifreFract = 0;
                foreach (char cifra in parteIntreaga)
                {
                    if (Char.IsDigit(cifra) && nrCifreInt >= 0)
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 48) * Math.Pow(bazaInit, nrCifreInt);
                    }
                    else
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 55) * (int)Math.Pow(bazaInit, nrCifreInt);
                    }
                }
                suma = sumaInt;
            }
            if (bazaTinta == 10)
                Console.WriteLine("Rezultatul=" + suma);
            else
            {
                int parteIntS = (int)suma;
                double parteFrs = suma - (int)suma;
                int rest;
                double produs = 0;
                Stack stInt = new Stack();
                Queue qFr = new Queue();
                while (parteIntS != 0)
                {
                    rest = parteIntS % bazaTinta;
                    if (rest >= 10)
                        stInt.Push((char)(rest + 55));
                    else
                        stInt.Push(rest);
                    parteIntS = (int)(parteIntS / bazaTinta);
                }
                if (parteFrs != 0)
                {
                    produs = parteFrs * bazaTinta;
                    if (produs >= 0)
                        qFr.Enqueue((char)(produs + 55));
                    else
                        qFr.Enqueue((int)produs);
                    parteFrs = produs - (int)produs;
                }
                Console.WriteLine("Result=");
                while ((produs - (int)produs) != 0) ;
                {
                    produs = parteFrs * bazaTinta;
                    qFr.Enqueue((int)produs);
                    parteFrs = produs - (int)produs;
                }
                while (stInt.Count != 0)
                {
                    Console.WriteLine(stInt.Peek());
                    stInt.Pop();
                }
                if (qFr.Count != 0)
                {
                    Console.WriteLine('.');
                    while (qFr.Count > 0)
                    {
                        Console.Write(qFr.Peek());
                        qFr.Dequeue();
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();

                    
                    

            }
        }
    }






