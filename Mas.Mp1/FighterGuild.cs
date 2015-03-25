using System.Collections.Generic;

namespace Mas.Mp1
{
    /// <summary>
    /// 
    /// </summary>
    public class FighterGuild : ObjectExtension
    {

        public FighterGuild(string name)
            :base()
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<Fighter> Fighters { get; set; }

        public void AssignFighter(Fighter fighter)
        {
            if (Fighters.Contains(fighter)) return;
            Fighters.Add(fighter);
            fighter.Guild = this;
        }
    }
}