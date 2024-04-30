using System.Text.RegularExpressions;

namespace EditorHtml {
    public class Visualizador {
        public static void Exibir(string texto) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("=================");
            Substituir(texto);
            Console.WriteLine("=================");
            Console.ReadKey();
            Menu.Exibir();
        }

        public static void Substituir(string texto) {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(" ");

            for(var i = 0; i < palavras.Length; i++) {
                if(strong.IsMatch(palavras[i])) {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') + 1,
                            (
                                (palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                } else {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        } 
    }
}