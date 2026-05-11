using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Encounter
    {
        private List <Character> characters = new List<Character>();
        public List <Character> Characters
        {
            get {return this.characters;} set {this.characters = value;}
        }
    }
}