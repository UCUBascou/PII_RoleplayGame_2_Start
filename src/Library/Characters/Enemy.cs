namespace Ucu.Poo.RolePlayGame
{
    public abstract class Enemy: Character
    {
        protected int victoryPoints;
        public int VictoryPoints
        {
            get { return this.victoryPoints; }
            set { this.victoryPoints = value; }
        }
    }
}