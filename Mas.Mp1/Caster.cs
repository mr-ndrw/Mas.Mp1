using System.Runtime.InteropServices.ComTypes;

namespace Mas.Mp1
{
    public static class Caster
    {
        public static T Cast<T>(object obj)
        {
            return (T) obj;
        }
    }
}