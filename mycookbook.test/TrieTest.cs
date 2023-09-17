namespace mycookbooklibrary.test
{
    public class TrieTest
    {
        [Test]
        public void CreateAndAddToTrie()
        {
            var trie = new Trie();
            trie.Add(1, "asparagus");

            Assert.That(trie, Is.Not.Null);
        }

        [Test]
        public void SearchTrie()
        {
            var trie = new Trie();
            trie.Add(1, "asparagus");
            trie.Add(2, "milk");

            Assert.That(trie.Search("asparagus"), Is.True);
            Assert.That(trie.Search("water"), Is.False);
            Assert.That(trie.Search("milk"), Is.True);
        }

        [Test]
        public void GetTopWords_ReturnsFirst3()
        {
            var trie = new Trie();
            trie.Add(1, "cheese");
            trie.Add(2, "cauliflower");
            trie.Add(3, "crabs");
            trie.Add(4, "clams");
            trie.Add(5, "corn");

            Assert.That(trie.GetSuggestions("c"), Is.EqualTo(
                new List<KeyValuePair<string, int>>
                    { new KeyValuePair<string, int>("cauliflower", 2),
                  new KeyValuePair<string, int>("cheese", 1),
                  new KeyValuePair<string, int>("clams", 4)
                    }));
        }

        [Test]
        public void GetTopWords_ReturnsNone()
        {
            var trie = new Trie();
            trie.Add(1, "water");
            trie.Add(2, "milk");
            trie.Add(3, "sugar");
            trie.Add(4, "salt");

            Assert.That(trie.GetSuggestions("a"), Is.Null);
        }

        [Test]
        public void GetTopWords_ReturnsLessThan3()
        {
            var trie = new Trie();
            trie.Add(1, "sugar");
            trie.Add(2, "salt");
            trie.Add(3, "milk");

            Assert.That(trie.GetSuggestions("s"), Is.EqualTo(
                new List<KeyValuePair<string, int>>
                    { new KeyValuePair<string, int>("salt", 2),
                  new KeyValuePair<string, int>("sugar", 1)
                }));
        }
    }
}