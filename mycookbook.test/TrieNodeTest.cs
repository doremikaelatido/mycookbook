namespace mycookbooklibrary.test
{
    public class TrieNodeTest
    {
        [TestCase('a')]
        [TestCase('b')]
        [TestCase('c')]
        public void CreateNewTrieNode(char charValue)
        {
            var trieNode = new TrieNode(charValue);

            Assert.That(trieNode.CharValue, Is.EqualTo(charValue));
            Assert.That(trieNode.Children, Is.Empty);
            Assert.That(trieNode.TopWords, Is.Empty);
        }

        [Test]
        public void CreateNewTrieNodeWithTopWord()
        {
            var trieNode = new TrieNode('a');
            trieNode.TopWords["asparagus"] = 1;

            Assert.That(trieNode.CharValue, Is.EqualTo('a'));
            Assert.That(trieNode.TopWords.First(), Is.EqualTo(new KeyValuePair<string, int>("asparagus", 1)));
        }

        [Test]
        public void AddChildToNode()
        {
            var trieNode = new TrieNode('a');
            var childTrieNode = new TrieNode('s');
            trieNode.Children.TryAdd(childTrieNode.CharValue, childTrieNode);

            var firstChild = trieNode.Children.First();
            Assert.That(trieNode.Children, Does.ContainKey(childTrieNode.CharValue));

            var childNodeFromDict = trieNode.Children[childTrieNode.CharValue];
            Assert.That(childNodeFromDict, Is.EqualTo(childTrieNode));
        }
    }

}
