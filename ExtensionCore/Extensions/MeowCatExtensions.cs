
using ExtensionCore.Models;
/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------
namespace ExtensionCore.Extensions
{
    public static class MeowCatExtensions
    {
        public static bool IsSameAge(this MeowCat meow, MeowCat otherMeow) =>
            meow.Age == otherMeow.Age;
        
    }
}
