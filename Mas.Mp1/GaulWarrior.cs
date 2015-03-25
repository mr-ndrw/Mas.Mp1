using System;

namespace Mas.Mp1
{
    public class GaulWarrior : Fighter
    {
        public GaulWarrior(string forename, string[] cognomens, string surname, int salary) 
            : base(forename, cognomens, surname, salary)
        {
        }

        public override void HitInTheFaceSpecial(Fighter fighter)
        {
            Console.WriteLine("{0} {1} hits {2} using his crafty Gaul special moves!", typeof(GaulWarrior), base.Forename, fighter.Forename);
        }
    }
}