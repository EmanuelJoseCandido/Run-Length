using System;

namespace Run_length
{
    class Program
    {
        public static string decodificacaoRLE;
        public static string codificacaoRLE;
        public static string menuR = "";
        public static char caractere;
        public static int contador = 0;
        public static int corredorDaRLE = 0;

        static void limpar()
        {
            decodificacaoRLE = "";
            codificacaoRLE = "";
            caractere = ' ';
            contador = 0;
            corredorDaRLE = 0;
        }

        static void codificarRLE()
        {
            for (int i = 0; i < decodificacaoRLE.Length; i++)
            {
                caractere = decodificacaoRLE[corredorDaRLE];
                if (caractere == decodificacaoRLE[i])
                {
                    contador++;
                }
                else
                {
                    codificacaoRLE += contador > 1 ? "" + contador + caractere : "" + caractere;
                    contador = 0;
                    corredorDaRLE = i;
                    i--;
                }
            }

            Console.WriteLine("Codificação: " + codificacaoRLE + ".");
            enter();
            menu();
        }

        static void decodificarRLE()
        {
            int numeroRLE = 0;
            string stringRLE = "";

            for(int i = 0; i<codificacaoRLE.Length; i++)
            {
                caractere = codificacaoRLE[i];

                try
                {
                    numeroRLE = int.Parse(caractere + "");
                    stringRLE += numeroRLE;
                }
                catch (Exception)
                {
                    try
                    {
                        numeroRLE = int.Parse(stringRLE);
                    }
                    catch (Exception) { }
                   
                    for(int c = 0; c < numeroRLE; c++)
                    {
                        decodificacaoRLE += caractere;
                    }
                    numeroRLE = 1;
                    stringRLE = "";
                }
            }
            Console.WriteLine("Decodificação: " + decodificacaoRLE + ".");
            enter();
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("* 1 - Codificação da RLE   *");
            Console.WriteLine("* 2 - Decodificação da RLE *");
            Console.WriteLine("* 3 - Sobe                 *");
            Console.WriteLine("* 4 - Sair                 *");
            Console.WriteLine("****************************");
            Console.Write("R: ");
            menuR = Console.ReadLine();
            lerStringsDeRLE();
        }

        static void lerStringsDeRLE()
        {
            Console.Clear();
            switch (menuR)
            {
                case "1": Console.Write("Digite o seu RLE: "); limpar(); decodificacaoRLE = Console.ReadLine(); decodificacaoRLE += " "; codificarRLE(); break;
                case "2": Console.Write("Digite o seu RLE: "); limpar(); codificacaoRLE = Console.ReadLine(); decodificarRLE(); break;
                case "3": sobre(); break;
                case "4": sair(); break;
                default:  menu(); break;
            }
        }

        static void sobre()
        {
            Console.Clear();
            Console.WriteLine("******************");
            Console.WriteLine("* 1 - Programa   *");
            Console.WriteLine("* 2 - Autor      *");
            Console.WriteLine("* 3 - Voltar     *");
            Console.WriteLine("******************");
            Console.Write("R: ");
            int menuSobre = int.Parse(Console.ReadLine());

            switch (menuSobre)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t Run-Length(RLE)\n\n\n");
                    Console.WriteLine("\nEmanuel Cândido\n");
                    Console.WriteLine("\nVersao 1.0\n\n\n");
                    Console.WriteLine("Copyrigth © 2020 EC Corporation. Todos os direiros Reservados.");
                    Console.WriteLine("O programa Run-Length(RLE) e a respectiva interface de utilizador");
                    Console.WriteLine("estão protegidos por marca registrada e outros direitos de propriedade");
                    Console.WriteLine("intelectual pendentes ou exitentes em Angola e noutros paises.");
                    enter();
                    sobre();
                break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\t\t\t     EMANUEL CÂNDIDO\n\n\n");
                    Console.WriteLine("Instagram: emaboy.");
                    Console.WriteLine("GitHub: EmanuelJoseCandido.");
                    Console.WriteLine("Email: emanueljosecandido@hotmail.com.");
                    Console.WriteLine("Website: www.facebook.com/EmanuelCandido.");
                    Console.WriteLine("Telefone: +244921815882 / +244990815882.\n\n");
                    enter();
                    sobre();
                break;

                case 3: menu(); break;
        
                default: menu(); break;
            }
        }

        static void sair()
        {
            Console.Clear();
            Console.WriteLine("\n\nA sair...");
            Console.WriteLine("\n \n \t \t \t \t \t \t \t \t \t \t \t \t ----------------------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t \t \t Autor: Emanuel Cândido");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t \t \t ---------------------- \n \n");
            enter();
        }

        static void enter()
        {
            Console.WriteLine("\n\n\nAperte em qualquer tecla para avançar...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
