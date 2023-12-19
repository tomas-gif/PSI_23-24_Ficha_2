using System;

namespace MiniJogo
{
    public abstract class Personagem
    {
        private int movimento;

        public int HP { get; set; }
        public int Escudo { get; set; }
        public virtual int Poder { get; set; }

        public Personagem(int movimento, int hp, int poder)
        {
            this.movimento = movimento;
            HP = hp;
            Escudo =  hp / 2;
            Poder = poder;
        }
        
        public virtual void Mover()
        {
            Console.WriteLine($"andou {movimento} unidades.");
        }

        public abstract void Enfrentar(Personagem p);
    }
}