using System;

namespace Mas.Mp1
{
    public class Mirmillo : Gladiator
    {
        public Mirmillo(string forename, string[] cognomens, string surname, int salary) 
            : base(forename, cognomens, surname, salary)
        {
           
        }

        public override void HitInTheFaceSpecial(Fighter fighter)
        {
            Console.WriteLine("{0} {1} hits {2} and catches him in his SPECIAL NET!", typeof(Mirmillo), base.Forename, fighter.Forename);
        }

        public void HitInTheFaceSpecial(GaulWarrior gaulWarrior)
        {
            Console.WriteLine("{0} {1} really hates catching dirty Gaul {2} with his SPECIAL NET!", typeof (Mirmillo), Forename,
                gaulWarrior.Forename);
        }
    }
}