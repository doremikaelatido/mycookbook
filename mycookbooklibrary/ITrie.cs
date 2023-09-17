namespace mycookbooklibrary
{
	public interface ITrie
	{
		void Add(int id, string ingredient);

		bool Search(string ingredient);

		List<KeyValuePair<string, int>>? GetSuggestions(string ingredient);
    }
}

