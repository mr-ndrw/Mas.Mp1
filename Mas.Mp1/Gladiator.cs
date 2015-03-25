using System;

namespace Mas.Mp1
{
    /// <summary>
    ///     Regular roman gladiator.
    /// </summary>
    public class Gladiator : Fighter
    {
        public Gladiator(string forename, string[] cognomens, string surname, int salary) 
            : base(forename, cognomens, surname, salary)
        {
        }

        public override void HitInTheFaceSpecial(Fighter fighter)
        {
            Console.WriteLine("{0} {1} hits {2} using special move!", typeof(Gladiator), base.Forename, fighter.Forename);
        }
    }
}