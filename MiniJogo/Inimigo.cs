using System;

namespace MiniJogo
{
    public class Inimigo : Personagem
    {
        public Inimigo(int mov, int hp, int poder) : base(mov, hp, poder) { }

        public override void Mover() 
        {
            Console.Write("Inimigo ");
            base.Mover();
        }

        public override void Enfrentar(Personagem p)
        {
            Console.WriteLine($"Inimigo detetou {p}!");
        }

        public override string ToString()
        {
            return "Inimigo";
        }
    }
}