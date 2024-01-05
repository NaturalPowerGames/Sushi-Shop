using UnityEngine;

namespace Cooking
{
	[CreateAssetMenu]
	public class IngredientsData : ScriptableObject
	{
		[EnumNamedArray(typeof(IngredientType))]
		public IngredientController[] Ingredients;
	}
}