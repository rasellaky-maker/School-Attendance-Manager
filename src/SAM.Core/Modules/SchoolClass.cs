using SAM.Core.Enums;

namespace SAM.Core.Modules
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public SchoolClassName Name { get; set; }

        public SchoolClass(int id, SchoolClassName name)
        {
            Id = id;
            Name = name;
        }
        public SchoolClass()
        { }


        public override string ToString()
        {
            return $"{Name.ToString()}";
        }
    }
}
