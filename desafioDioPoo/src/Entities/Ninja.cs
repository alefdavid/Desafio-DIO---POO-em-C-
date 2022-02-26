namespace desafioDioPoo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public String AttackNinja(int Bonus)
        {
            if (Bonus >= 10)
            {
                return this.Name + " Atacou com sua Super Estrela de Arremesso com bonus de " + Bonus + "!";
            }else{
                return this.Name + " Atacou com sua Estrela de Arremesso com bonus de " + Bonus + "!";
            }           
        }
    }
}