using System;

namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("Em que dia você nasceu?");
            dia = Console.ReadLine();

            Console.WriteLine("Em que mes você nasceu?");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            InterpretadorDeSigno interpretador = new InterpretadorDeSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if (signo != null)
            {
                Console.WriteLine("O seu signo é de " + signo.nome + " ! " + signo.caracteristicas);
            }else
            {
                Console.WriteLine("Não foi possível interpretar seu signo, tente novamente");
            }
               Console.ReadLine();
        }
    }
}
