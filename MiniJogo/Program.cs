using System;

namespace MiniJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem j = new Jogador(5, 100, 50);
            Personagem i = new Inimigo(10, 50, 20);

            j.Mover();
            i.Mover();
            i.Enfrentar(j);
            j.Enfrentar(i);
        }
    }
}
