using System;
using System.Linq;

namespace Mas.Mp1
{
    /// <summary>
    ///     Base class for all warrior classes containing all basic and common information about one warrior.
    /// </summary>
    public abstract class Fighter : ObjectExtension
    {
        protected Fighter(string forename, string[] cognomens, string surname, int salary)
        {
            Forename = forename;
            Cognomens = cognomens;
            Surname = surname;
            Salary = salary;
        }

        /// <summary>
        ///     Fighter's forename.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        ///     Cognomens(personal or hereditary names) of the fighter.
        /// </summary>
        public string[] Cognomens { get; set; }

        /// <summary>
        ///     Figher's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        ///     Fighter's salary.
        /// </summary>
        public int Salary { get; private set; }

        /// <summary>
        ///     Value from 0.0 to 1.0 denoting the maximum percentage change in Figther's salary.
        /// </summary>
        public static double MaxSalaryChange { get; set; }

        /// <summary>
        ///     Address of the indivual fighter.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        ///     The group to which the fighter belongs.
        /// </summary>
        public FighterGuild Guild { get; set; }

        /// <summary>
        ///     Returns the salaries of all the fighters present.
        /// </summary>
        public static int Salaries
        {
            get
            {
                return ExtentDictionary.Where(pair => pair.Key.IsSubclassOf(typeof (Fighter)))
                                       .Sum(
                                           pair =>
                                               pair.Value.Select(o => (o as Fighter).Salary)
                                                   .Sum());
            }
        }

        /// <summary>
        ///     Changes the salary of the fighter while taking into account the maximum possible change in his salary.
        /// </summary>
        /// <param Forename="newSalary">
        ///     New salary.
        /// </param>
        /// <returns>
        ///     Returns whether the change was successful or not.
        /// </returns>
        public bool ChangeSalary(int newSalary)
        {
            var salaryQuotient = (double) newSalary/Salary;
            var decimalPart = salaryQuotient - Math.Floor(salaryQuotient);

            if (decimalPart > MaxSalaryChange)
            {
                return false;
            }

            Salary = newSalary;
            return true;
        }

        public void HitInTheFace(Fighter otherFighter)
        {
            Console.WriteLine("{0} hits {1} in the face normally.", Forename, otherFighter.Forename);
        }

        public abstract void HitInTheFaceSpecial(Fighter fighter);
    }
}