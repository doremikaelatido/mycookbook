namespace mycookbooklibrary
{
    public class Trie : ITrie
    {
        TrieNode _root;

        public Trie()
        {
            _root = new TrieNode('*');
        }

        public void Add(int id, string ingredient)
        {
            var curr = _root;

            foreach (char letter in ingredient)
            {
                TrieNode childNode;

                if (!curr.Children.ContainsKey(letter))
                {
                    childNode = new TrieNode(letter);
                    curr.Children[letter] = childNode;
                }
                else
                {
                    childNode = curr.Children[letter];
                }
                childNode.TopWords[ingredient] = id;
                curr = childNode;
            }
        }

        public bool Search(string ingredient)
        {
            var curr = _root;

            foreach (char letter in ingredient)
            {
                if (!curr.Children.ContainsKey(letter))
                {
                    return false;
                }
                curr = curr.Children[letter];
            }
            return true;
        }

        public List<KeyValuePair<string, int>>? GetSuggestions(string ingredient)
        {
            var curr = _root;
            foreach (char letter in ingredient)
            {
                if (!curr.Children.ContainsKey(letter))
                {
                    return null;
                }
                curr = curr.Children[letter];
            }
            var suggestions = curr.TopWords.ToArray()[0..Math.Min(3, curr.TopWords.Count)];
            return suggestions.ToList();
        }
    }
}