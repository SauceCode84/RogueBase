namespace RogueBase.Classes
{
    public abstract class MagicEntity :
        Entity
    {
        private int mana;

        public MagicEntity()
        { }

        public MagicEntity(string name) :
            base(name)
        { }

        public int Mana
        {
            get { return mana; }
            set
            {
                mana = value;

                if (mana > ManaMax)
                {
                    mana = ManaMax;
                }

                if (mana < 0)
                {
                    mana = 0;
                }
            }
        }

        public int ManaMax { get; set; }

        public bool IsManaDepleted()
        {
            return Mana == 0;
        }
    }
}
