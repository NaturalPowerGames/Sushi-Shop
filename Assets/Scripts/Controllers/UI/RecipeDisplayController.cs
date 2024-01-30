using UnityEngine;
using TMPro;

namespace Cooking
{
	public class RecipeDisplayController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI recipeName, reward, ingredients;

		public void Initialize(Recipe recipe)
		{
			this.recipeName.text = recipe.Name;
			this.reward.text = recipe.Reward.ToString();
			string ingredientsOneLine = "";
			foreach (IngredientType ingredient in recipe.ingredients)
			{
				ingredientsOneLine += $"{ingredient}";
			}
			this.ingredients.text = ingredientsOneLine;
		}
	}
}