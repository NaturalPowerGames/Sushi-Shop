using Patrons;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
	public class RecipeManager : MonoBehaviour
	{
		[SerializeField]
		private RecipeData recipeData;	
		private Dictionary<PatronController, Recipe> PatronRequirements = new Dictionary<PatronController, Recipe>();

		private void OnEnable()
		{
			PatronEvents.OnPatronSat += OnPatronSat;
			PatronEvents.OnPatronSatisfied += OnPatronSatisfied;
		}

		private void OnPatronSat(PatronController patron)
		{
			var recipeForPatron = recipeData.GetRandomRecipe();
			PatronRequirements.Add(patron, recipeForPatron);
			PatronEvents.OnPatronRequirementsChanged?.Invoke(PatronRequirements);
		}

		private void OnPatronSatisfied(PatronController patron)
		{
			PatronRequirements.Remove(patron);
			PatronEvents.OnPatronRequirementsChanged?.Invoke(PatronRequirements);
		}
	}
}