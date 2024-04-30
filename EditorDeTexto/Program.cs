namespace EditorDeTexto {

    class Programa {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();

            Console.WriteLine("===========================");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar novo arquivo");
            Console.WriteLine("0- Sair");
            Console.WriteLine("===========================");
            
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao) {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir() {
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho)) {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Thread.Sleep(2000);
            Menu();
        }

        static void Editar() {
            Console.Clear();

            Console.WriteLine("Digite o seu texto abaixo (ESC => Sair):");
            Console.WriteLine("--------------------------");
            string texto = "";
            
            do {
                texto += Console.ReadLine() + "\n";
                //texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
                
            Salvar(texto);
        }

        static void Salvar(string texto) {
            Console.Clear();

            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using(var arquivo = new StreamWriter(caminho)) {
                arquivo.Write(texto);
            }

            Console.Clear();
            Console.WriteLine($"Arquivo '{caminho}' salvo com sucesso!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}