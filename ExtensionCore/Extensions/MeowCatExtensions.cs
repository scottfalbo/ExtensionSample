
using ExtensionCore.Models;
using System.Runtime.CompilerServices;
/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------
namespace ExtensionCore.Extensions
{
    public static class MeowCatExtensions
    {
        public static bool IsSameAge(this MeowCat meow, MeowCat otherMeow) =>
            meow.Age == otherMeow.Age;

        public static bool IsSameType(this MeowCat meow, MeowCat otherMeow) =>
            meow.Type == otherMeow.Type;
        
        public static bool IsSameAgeAndType(this MeowCat meow, MeowCat otherMeow) =>
            meow.Type == otherMeow.Type && meow.Age == otherMeow.Age;

        public static void GetInfo(this MeowCat meow)
        {
            Console.WriteLine($"Name: {meow.Name}");
            Console.WriteLine($"Age: {meow.Name}");
            Console.WriteLine($"Type: {meow.Name}");
        }
    }
}
