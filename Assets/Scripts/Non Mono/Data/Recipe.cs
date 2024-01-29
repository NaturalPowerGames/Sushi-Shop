namespace Cooking
{
	[System.Serializable]
	public class Recipe
	{
		public string Name;
		public IngredientType[] ingredients;
		public int Reward;
	}
}