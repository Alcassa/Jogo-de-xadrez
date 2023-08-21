using Xadrez.tabuleiro;
using Xadrez.xadrez;


namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Amarelo), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 9));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}