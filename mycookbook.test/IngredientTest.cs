namespace mycookbooklibrary.test
{
    public class IngredientTest
    {
        [Test]
        public void CreateNewIngredient()
        {
            var ingredient = new Ingredient(1, "water");

            Assert.That(ingredient.Name, Is.EqualTo("water"));
            Assert.That(ingredient.Id, Is.EqualTo(1));
        }
    }
}
