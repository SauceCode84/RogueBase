namespace RogueBase.Classes
{
    public abstract class Entity
    {
        private int health;

        public Entity()
        { }

        public Entity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Health
        {
            get { return health; }
            set
            {
                health = value;

                if (health > HealthMax)
                {
                    health = HealthMax;
                }

                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public int HealthMax { get; set; }

        public bool IsDead()
        {
            return Health == 0;
        }
    }
}
