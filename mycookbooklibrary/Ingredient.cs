namespace mycookbooklibrary
{
    public class Ingredient
    {
        public Ingredient(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}