/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------

using ExtensionCore.Models;

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
            Console.WriteLine($"\nName: {meow.Name}");
            Console.WriteLine($"Age: {meow.Age}");
            Console.WriteLine($"Type: {meow.Type}");

            var cattributes = meow.GetCattributes();
            foreach (var cattribute in cattributes)
            {
                Console.WriteLine($"- {cattribute}");
            }
        }

        public static int GetCattributeCount(this MeowCat meow ) => meow.GetCattributes().Count;

        public static int GetSharedCattributesCount(this MeowCat meow, MeowCat otherMeow)
        {
            var cattributes = meow.GetCattributes();
            var otherCattributes = otherMeow.GetCattributes();
            var count = 0;

            foreach (var cattribute in cattributes)
            {
                if (otherCattributes.Contains(cattribute))
                {
                    count++;
                }
            }

            return count;
        }
    }
}