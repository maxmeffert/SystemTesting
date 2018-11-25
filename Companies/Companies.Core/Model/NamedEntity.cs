namespace Companies.Core.Model
{
    public class NamedEntity 
    {
        public string Name { get; set; } 

        public override string ToString()
        {
            return Name;
        }
    }
}
