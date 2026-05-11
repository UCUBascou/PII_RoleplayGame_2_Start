namespace Ucu.Poo.RolePlayGame
{
    public abstract class Hero: Character
    {
        protected int accumulatedVictoryPoints = 0;
        public int AccumulatedVictoryPoints
        {
            get { return this.accumulatedVictoryPoints; }
            set { this.accumulatedVictoryPoints = value; }
        }
    }
}