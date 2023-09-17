namespace mycookbooklibrary
{
	public class TrieNode
	{
		public TrieNode(char charValue)
		{
			this.CharValue = charValue;
			this.TopWords = new SortedDictionary<string, int>();
			this.Children = new Dictionary<char, TrieNode>();
		}

        public SortedDictionary<string, int> TopWords { get; set; }

        public char CharValue { get; set; }

		public Dictionary<char, TrieNode> Children { get; set; }
    }
}

