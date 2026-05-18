namespace Ucu.Poo.RolePlayGame
{
    public abstract class Hero: Character
    {
        protected int baseVictoryPoints = 0;
        public int BaseVictoryPoints
        {
            get { return this.baseVictoryPoints; }
            set { this.baseVictoryPoints = value; }
        }
        protected int accumulatedVictoryPoints = 0;
        public int AccumulatedVictoryPoints
        {
            get { return this.accumulatedVictoryPoints; }
            set { this.accumulatedVictoryPoints = value; }
        }
    }
}