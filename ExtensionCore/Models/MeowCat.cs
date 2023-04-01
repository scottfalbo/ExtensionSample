/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------

namespace ExtensionCore.Models
{
    public class MeowCat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public MeowCat(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
    }
}