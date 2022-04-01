using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


class Program
    { 
        static void Main(string[] args)
        {
            
       //String caminho = Server.MapPath(@"~/tel.txt");
             StreamReader arq = new StreamReader(@"C:\ListTel\ListTel\tel.txt");
        //StreamReader arq = new StreamReader(caminho);

            string linha;
           int cont = 0;
            string[] vetor = new string[1052];
           
            while (arq.EndOfStream == false)
            {
                linha = arq.ReadLine();

                vetor[cont] = linha.Trim();


                cont++;
            }
            arq.Close();

            ///////FIM//////////



            StreamWriter  LISTA = new StreamWriter(@"ListTelEd.txt", true);

            for (int POS = 0; POS < cont; POS++)
            {

            if (vetor[POS].Length == 11)
            {
                LISTA.Write("55" + vetor[POS]);
                LISTA.WriteLine("");
            }
            else if (vetor[POS].Length == 10)
            {
                LISTA.Write("55" + vetor[POS]);
                LISTA.WriteLine("");
            }
            else if (vetor[POS].Length == 9)
            {
                LISTA.Write("5518" + vetor[POS]);
                LISTA.WriteLine("");
            }
            else
            {
                LISTA.Write(vetor[POS]);
                LISTA.WriteLine("");
            }
            }

               LISTA.Close();
            //WHATSAPP.Write("/ip firewall address-list add address= \"" + vetor[POS] + "\"  list= \"whatsapp\"\n");
            //WHATSAPP.WriteLine("");
            Console.WriteLine("FINALIZADO!!");
            Console.ReadKey();
            }

           
        }
