namespace POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 8)
            {
                return this.name + " Lançou uma magia super efetiva com bonus de ataque de " + Bonus;

            }
            else
            {
                return this.name + " Lançou uma magia com força fraca com bonus de ataque de " + Bonus;

            }

        }
    }
}