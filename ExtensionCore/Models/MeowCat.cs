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
        public List<string> Cattributes { get; set; }

        public MeowCat(string name, int age, string type, string[] cattributes)
        {
            Name = name;
            Age = age;
            Type = type;
            Cattributes = cattributes.ToList();
        }
    }
}