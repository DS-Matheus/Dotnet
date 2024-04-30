namespace EditorHtml
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Menu.DesenharTela(30, 10);

            var opcao = short.Parse(Console.ReadLine());
            ProcessarEscolhaMenu(opcao);
        }

        public static void DesenharLimites(int tamanho)
        {
            Console.Write("+");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DesenharLinhas(int largura, int altura)
        {
            for (int i = 0; i < altura; i++)
            {
                Console.Write("|");
                for (int j = 0; j < largura; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void EscreverOpcoes() {
            Console.SetCursorPosition(10,2);
            Console.WriteLine("Editor Html");
            
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(3,6);
            Console.WriteLine("1: Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2: Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0: Sair");

            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");

        }

        public static void DesenharTela(int largura, int altura) {
                DesenharLimites(largura);
                DesenharLinhas(largura, altura);
                DesenharLimites(largura);

                EscreverOpcoes();
        }

        public static void ProcessarEscolhaMenu(short opcao) {
            switch(opcao) {
                case 1: Editor.Exibir(); break;
                case 2: Console.Write("Visualizar"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Menu.Exibir(); break;
            }
        }
    }
}