using System;

namespace MiniJogo
{
    public class Jogador : Personagem
    {
        public int XP { get; set; }
        public override int Poder => base.Poder + XP;

        public Jogador(int mov, int hp, int poder) : base(mov, hp, poder)
        {
            XP = 0;
        }

        public override void Mover() 
        {
            Console.Write("Jogador ");
            base.Mover();
        }

        public override void Enfrentar(Personagem p)
        {
            Console.WriteLine($"Jogador atacou {p} e deu {Poder} pontos de dano!");
        }

        public override string ToString()
        {
            return "Jogador";
        }
    }
}