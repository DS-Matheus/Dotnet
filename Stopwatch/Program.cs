namespace Stopwatch
{
    class Programa
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("S: Segundos => 10s = 10 segundos");
            Console.WriteLine("M: Minutos  => 10m = 10 minutos");
            Console.WriteLine("0: Sair");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("===================================");

            string inputTempo = Console.ReadLine().ToLower();
            int tempoEscolhido = int.Parse(inputTempo.Substring(0, inputTempo.Length -1));
            char medidaEscolhida = char.Parse(inputTempo.Substring(inputTempo.Length -1, 1));
            
            int multiplicador = 1;
            if (medidaEscolhida == 'm') {
                multiplicador = 60;
            }

            if (tempoEscolhido == 0){
                System.Environment.Exit(0);
            }
            
            PreIniciar(tempoEscolhido * multiplicador);
        }

        static void PreIniciar(int tempo) {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(2500);

            Console.Clear();
            Console.WriteLine("Apontar..");
            Thread.Sleep(1500);
            
            Console.Clear();
            Console.WriteLine("VAI!");
            Thread.Sleep(750);

            Iniciar(tempo);
        }

        static void Iniciar(int tempoConfigurado) {
            int tempoLimite = tempoConfigurado;
            int tempoAtual = 0;

            while (tempoAtual != tempoLimite)
            {
                Console.Clear();
                tempoAtual++;

                int minutos = (int)(tempoAtual/60);
                int segundos;
                if (minutos > 0) {
                    segundos = tempoAtual % (60*minutos);
                }
                else {
                    segundos = tempoAtual;
                }

                Console.WriteLine($"{minutos}:{segundos}");              
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
    }
}