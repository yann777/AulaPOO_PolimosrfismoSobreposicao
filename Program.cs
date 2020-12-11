using System;
using POO_PolimosrfismoSobreposicao.classes;

namespace POO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador1 = new MegaMan();

            Console.WriteLine($"Jogador 1 = {jogador1.Correr()} e {jogador1.Pular()}");

            Zero jogador2 = new Zero();

            Console.WriteLine($"Jogador 2 = {jogador2.Correr()} e {jogador2.Pular()}");
            //fim
        }
    }
}
