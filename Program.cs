using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELIPE_CASSIMIRO01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nome Felipe Cassimiro
           
            int[][] IDS1 = new int[6][];
            int[][] IDS2 = new int[6][];
            int[][] IDS3 = new int[6][];
            int[][] IDS4 = new int[6][];

                // estoque produto 01 
                for (int i = 0; i < IDS1.Length; i++)
                {
                    IDS1[i] = new int[6];
                }
                for (int i = 0; i > IDS1.Length; i++)
                {
                    for (int j = 0; j < IDS1[i].Length; j++)
                    {
                        if (i < 2)
                        {
                            break;
                        }
                    }
                }
                //Preenchendo a metade do estoque. 
                for (int t = 0; t < IDS1.Length; t++)
                {
                    for (int q = 0; q < IDS1[t].Length; q++)
                    {
                        if (t < 3)
                        {
                            IDS1[t][q] = 1;
                        }
                    }
                }
                //estoque 2
                for (int i = 0; i < IDS2.Length; i++)
                {
                    IDS2[i] = new int[6];
                }
                for (int i = 0; i > IDS2.Length; i++)
                {
                    for (int j = 0; j < IDS2[i].Length; j++)
                    {
                        if (i < 2)
                        {
                            break;
                        }
                    }
                }
                //Preenchendo a metade do estoque. 
                for (int t = 0; t < IDS2.Length; t++)
                {
                    for (int q = 0; q < IDS2[t].Length; q++)
                    {
                        if (t < 3)
                        {
                            IDS2[t][q] = 2;

                        }
                    }
                }
                    //estoque 03
                for (int i = 0; i < IDS3.Length; i++)
                {
                    IDS3[i] = new int[6];
                }
                for (int i = 0; i > IDS3.Length; i++)
                {
                    for (int j = 0; j < IDS3[i].Length; j++)
                    {
                        if (i < 2)
                        {
                            break;
                        }
                    }
                }
                //Preenchendo a metade do estoque. 
                for (int t = 0; t < IDS3.Length; t++)
                {
                    for (int q = 0; q < IDS3[t].Length; q++)
                    {
                        if (t < 3)
                        {
                            IDS3[t][q] = 3;
                        }
                    }
                }
                //estoque04
                for (int i = 0; i < IDS4.Length; i++)
                {
                    IDS4[i] = new int[6];
                }
                for (int i = 0; i > IDS4.Length; i++)
                {
                    for (int j = 0; j < IDS4[i].Length; j++)
                    {
                        if (i < 2)
                        {
                            break;
                        }
                    }
                }
                //Preenchendo a metade do estoque. 
                for (int t = 0; t < IDS4.Length; t++)
                {
                    for (int q = 0; q < IDS4[t].Length; q++)
                    {
                        if (t < 3)
                        {
                            IDS4[t][q] = 4;
                        }
                    }
                }
            Console.WriteLine("   ");
            Console.WriteLine(" \n  \n \n  \n \n            ♣                            SEJAM BEM VINDOS                ♣ \n");
            Console.WriteLine("            ♣               CASSIMIRO'S TRANSPORTATION AND LOGISTICS     ♣");
            Console.WriteLine(" \n ");
            Console.WriteLine();
            Console.WriteLine("                             ░░APERTE O ENTER PARA COMEÇAR O DIA!░░   ");
            Console.WriteLine("\n");
            Console.WriteLine("  \n                                                 Desenvolvedor FELIPE CASSIMIRO.");

            Console.ReadLine();
            Console.Clear();
            //Mostrando na tela o estoque com a metade preenchida. 
            Console.WriteLine(" ESTOQUE COM A MEDATE PREENCHIDA:");
            Console.WriteLine("  ESTOQUE 01");
            Console.WriteLine("═══════════╗");
            for (int i = 0; i < IDS1.Length; i++)
            {
                for (int j = 0; j < IDS1[i].Length; j++)
                {
                    Console.Write(+IDS1[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("═══════════╝");
            Console.WriteLine("  ESTOQUE 02 ");
            Console.WriteLine("═══════════╗");
            for (int i = 0; i < IDS2.Length; i++)
            {
                for (int j = 0; j < IDS2[i].Length; j++)
                {
                    Console.Write(+IDS2[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("═══════════╝ ");

            Console.WriteLine("  ESTOQUE 03 ");
            Console.WriteLine("═══════════╗");
            for (int i = 0; i < IDS3.Length; i++)
            {
                for (int j = 0; j < IDS3[i].Length; j++)
                {
                    Console.Write(IDS3[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("═══════════╝");
            Console.WriteLine("  ESTOQUE 04");
            Console.WriteLine("═══════════╗");
            for (int i = 0; i < IDS4.Length; i++)
            {
                for (int j = 0; j < IDS4[i].Length; j++)
                {
                    Console.Write(IDS4[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("═══════════╝");

                Console.WriteLine("░░APERTE O ENTER PARA COMEÇAR O DIA!░░ ");
                Console.ReadLine();
                 Console.Clear();
            for (int loop = 0; loop < 6; loop++)
            {                              
                Console.WriteLine(" ╔══════════╗");
                Console.WriteLine(" ║  Dia " + (loop + 1) + "   ║");
                Console.WriteLine(" ╚══════════╝");

                Console.WriteLine("\n");
                Console.WriteLine("░░Recebimento de cargas░░ ");
                //Gerando a Carga e armazenando no estoque.
                Console.WriteLine("\n");
                List<string> entrada = new List<string>();
                int Quantidade = Geradores.Qtd();
                for (int i = 0; i < Quantidade; i++)
                {
                    entrada = Geradores.GeraEntrada();
                    Console.WriteLine("╔══════════╗");
                    Console.WriteLine("║ Carga" + (i + 1) + "   ║");
                    Console.WriteLine("╚══════════╝");

                    foreach (var item in entrada)
                    {
                        Console.Write(item);
                        if (item == "1")
                        {
                            for (int a = 0; a < IDS1.Length; a++)
                            {
                                for (int b = 0; b < IDS1[a].Length; b++)
                                {
                                    if (IDS1[a][b] == 0)
                                    {

                                        IDS1[a][b] = 1;
                                        a = 20;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == "2")
                        {
                            for (int a = 0; a < IDS2.Length; a++)
                            {
                                for (int b = 0; b < IDS2[a].Length; b++)
                                {
                                    if (IDS2[a][b] == 0)
                                    {

                                        IDS2[a][b] = 2;
                                        a = 20;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == "3")
                        {
                            for (int a = 0; a < IDS3.Length; a++)
                            {
                                for (int b = 0; b < IDS3[a].Length; b++)
                                {
                                    if (IDS3[a][b] == 0)
                                    {

                                        IDS3[a][b] = 3;
                                        a = 20;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == "4")
                        {
                            for (int a = 0; a < IDS4.Length; a++)
                            {
                                for (int b = 0; b < IDS4[a].Length; b++)
                                {
                                    if (IDS4[a][b] == 0)
                                    {

                                        IDS4[a][b] = 4;
                                        a = 20;
                                        break;
                                    }

                                }
                            }

                        }
                    }

                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");

                Console.WriteLine("♣ ESTOQUE ATUALIZADO ♣");
                //mostrando na tela o estoque após de receber a carga.
                Console.WriteLine("  ESTOQUE 01");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS1.Length; i++)
                {
                    for (int j = 0; j < IDS1[i].Length; j++)
                    {
                        Console.Write(+IDS1[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("  ESTOQUE 02 ");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS2.Length; i++)
                {
                    for (int j = 0; j < IDS2[i].Length; j++)
                    {
                        Console.Write(+IDS2[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝ ");
                Console.WriteLine("  ESTOQUE 03 ");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS3.Length; i++)
                {
                    for (int j = 0; j < IDS3[i].Length; j++)
                    {
                        Console.Write(IDS3[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("  ESTOQUE 04");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS4.Length; i++)
                {
                    for (int j = 0; j < IDS4[i].Length; j++)
                    {
                        Console.Write(IDS4[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("░░APERTE O ENTER PARA GERAR A ORDEM DE SERVIÇO!░░ ");
                Console.ReadLine();
                
                Console.WriteLine(" ♣ ORDEM DE SERVIÇO ♣");
                int Quant = Geradores.Qtd();
                //recebe ordem de serviço converte para char e depois converte para interno 
                for (int i = 0; i < Quant; i++)
                {                   
                    string saidaservico = Geradores.OrdemDeServico();
                    saidaservico = SortManual(saidaservico);
                    char[] ordem = saidaservico.ToCharArray(0, saidaservico.Length);//conversão de do vetor string para vetor char.
                    int[] ordemServ = new int[ordem.Length];// conversão de vetor char para vetor de int.
                    for (int d = 0; d < ordem.Length; d++)
                    {
                        if (ordem[d] == '1')
                        {
                            ordemServ[d] = 1;
                        }
                        else if (ordem[d] == '2')
                        {
                            ordemServ[d] = 2;
                        }
                        else if (ordem[d] == '3')
                        {
                            ordemServ[d] = 3;
                        }
                        else if (ordem[d] == '4')
                        {
                            ordemServ[d] = 4;
                        }
                    }
                    foreach (var item in ordemServ)
                    {
                        Console.Write(item);

                        if (item == 1)
                        {
                            for (int a = 5; a >= 0; a--)
                            {
                                for (int b = 5; b >= 0; b--)
                                {
                                    if (IDS1[a][b] == 1)
                                    {
                                        IDS1[a][b] = 0;
                                        a = -30;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == 2)
                        {
                            for (int a = 5; a >= 0; a--)
                            {
                                for (int b = 5; b >= 0; b--)
                                {
                                    if (IDS2[a][b] == 2)
                                    {
                                        IDS2[a][b] = 0;
                                        a = -30;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == 3)
                        {
                            for (int a = 5; a >= 0; a--)
                            {
                                for (int b = 5; b >= 0; b--)
                                {
                                    if (IDS3[a][b] == 3)
                                    {
                                        IDS3[a][b] = 0;
                                        a = -30;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (item == 4)
                        {
                            for (int a = 5; a >= 0; a--)
                            {
                                for (int b = 5; b >= 0; b--)
                                {
                                    if (IDS4[a][b] == 4)
                                    {
                                        IDS4[a][b] = 0;
                                        a = -30;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    Console.WriteLine(" ");
                }
                Console.WriteLine(" \n");
                Console.WriteLine("░░SAIDA de cargas░░");
                Console.WriteLine(" ESTOQUE 01");
                Console.WriteLine("\n ");
                Console.WriteLine("═══════════╗");

                for (int i = 0; i < IDS1.Length; i++)
                {
                    for (int j = 0; j < IDS1[i].Length; j++)
                    {
                        Console.Write(IDS1[i][j] + " ");

                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("\n");
                Console.WriteLine(" ESTOQUE 02");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS2.Length; i++)
                {
                    for (int j = 0; j < IDS2[i].Length; j++)
                    {
                        Console.Write(IDS2[i][j] + " ");

                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("\n");
                Console.WriteLine("  ESTOQUE 03");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS3.Length; i++)
                {
                    for (int j = 0; j < IDS3[i].Length; j++)
                    {
                        Console.Write(IDS3[i][j] + " ");

                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");

                Console.WriteLine("  ESTOQUE 04");
                Console.WriteLine("═══════════╗");
                for (int i = 0; i < IDS4.Length; i++)
                {
                    for (int j = 0; j < IDS4[i].Length; j++)
                    {
                        Console.Write(IDS4[i][j] + " ");

                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("═══════════╝");
                Console.WriteLine("░░FIM DE ESPEDIENTE!░░ ");
                Console.WriteLine("\n");
                Console.WriteLine("░░APERTE O ENTER PARA INICIAR UM NOVO DIA!░░ ");
                Console.ReadLine();               
                Console.Clear();
            }
        }
        public static string SortManual(string entrega)
        {
            char[] palavra = new char[entrega.Length];
            for (int i = 0; i < entrega.Length; i++)
            {
                palavra[i] = entrega[i];
            }

            for (int i = 0; i < entrega.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Convert.ToInt32(palavra[j]) < Convert.ToInt32(palavra[j - 1]))
                    {
                        char a;
                        a = palavra[j];
                        palavra[j] = palavra[j - 1];
                        palavra[j - 1] = a;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            entrega = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                entrega += palavra[i].ToString();
            }
            return entrega;
        }
    }
}
