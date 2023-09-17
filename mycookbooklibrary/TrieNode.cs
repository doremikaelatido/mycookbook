namespace mycookbooklibrary
{
    public class TrieNode
    {
        private char charValue;

        public TrieNode(char charValue)
        {
            this.charValue = charValue;
        }

        public char CharValue { get { return charValue; } }
        public Dictionary<char, TrieNode> Children { get; internal set; }
        public List<KeyValuePair<string, int>> TopWords { get; internal set; }
    }
}