using UnityEngine;
using TMPro;
using System;
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
			string ingredientsParsed = "";
			foreach (IngredientType ingredient in recipe.ingredients)
			{
				ingredientsParsed += $"{ingredient}{Environment.NewLine}";
			}
			this.ingredients.text = ingredientsParsed;
		}
	}
}