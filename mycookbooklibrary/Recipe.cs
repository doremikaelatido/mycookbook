namespace mycookbooklibrary
{
    public class Recipe
    {
        public Recipe(string recipeName, string duration)
        {
            this.RecipeName = recipeName;
            this.Duration = duration;
        }

        public string RecipeName { get; set; }
        public string Duration { get; set; }
    }
}