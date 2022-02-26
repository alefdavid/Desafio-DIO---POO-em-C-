namespace desafioDioPoo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(String Name, int Level, String HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType; 
        }        
        public override String Attack()
        {
            return this.Name + " Lançou magia";
        }    
        public String AttackWhiteWizard(int Bonus)
        {
            if (Bonus >= 10)
            {
                return this.Name + " Lançou magia efetiva com bonus de " + Bonus + "!";
            }else{
                return this.Name + " Lançou magia fraca com bonus de " + Bonus + "!";
            }
        }
        public String AttackBlackWizard(int Bonus)
        {
            if (Bonus >= 10)
            {
                return this.Name + " Lançou magia negra efetiva com bonus de " + Bonus + "!";
            }else{
                return this.Name + " Lançou magia negra fraca com bonus de " + Bonus + "!";
            }  
        }
    }    
}