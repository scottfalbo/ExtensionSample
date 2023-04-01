/// ------------------------------------
/// Basic use of Extensions sample code
/// ------------------------------------

namespace ExtensionCore.Models
{
    public class MeowCat
    {
        private List<string> _cattributes { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public MeowCat(string name, int age, string type, string[] cattributes)
        {
            Name = name;
            Age = age;
            Type = type;
            _cattributes = cattributes.ToList();
        }

        public List<string> GetCattributes() => _cattributes;
    }
}