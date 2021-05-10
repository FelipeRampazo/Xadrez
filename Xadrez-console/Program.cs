using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    try { 
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                    

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                 
                    partida.validarPosicaoDeOrigem(origem);
                    
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPosiveis();


                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                        partida.validarPosicaoDedestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                     

                    }
                    
                    catch(TabuleiroExcepition e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);

            }

            catch (TabuleiroExcepition e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
