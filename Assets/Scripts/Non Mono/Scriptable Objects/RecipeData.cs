using UnityEngine;

namespace Cooking
{
	[CreateAssetMenu]
	public class RecipeData : ScriptableObject
	{
		public Recipe[] Recipes;

		public Recipe GetRandomRecipe()
		{
			int randomIndex = UnityEngine.Random.Range(0, Recipes.Length);
			return Recipes[randomIndex];
		}
	}
}