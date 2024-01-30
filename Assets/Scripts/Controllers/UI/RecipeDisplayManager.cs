using Patrons;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
	public class RecipeDisplayManager : MonoBehaviour
	{
		[SerializeField]
		private RecipeDisplayController displayPrefab;
		private Dictionary<PatronController, RecipeDisplayController> recipeDisplays = new Dictionary<PatronController, RecipeDisplayController>();

		private void OnEnable()
		{
			PatronEvents.OnPatronRequirementsChanged += OnPatronRequirementsChanged;
		}

		private void OnDisable()
		{
			PatronEvents.OnPatronRequirementsChanged -= OnPatronRequirementsChanged;
		}

		private void OnPatronRequirementsChanged(Dictionary<PatronController, Recipe> requirements)
		{
			UpdateRequirements(requirements);
		}

		private void UpdateRequirements(Dictionary<PatronController, Recipe> requirements)
		{
			foreach (PatronController patron in requirements.Keys)
			{
				if (recipeDisplays.ContainsKey(patron))
				{
					continue;
				}
				else
				{
					var display = Instantiate(displayPrefab, this.transform);
					display.Initialize(requirements[patron]);
					recipeDisplays.Add(patron, display);
				}
			}

			foreach (PatronController patron in recipeDisplays.Keys)
			{
				if (requirements.ContainsKey(patron))
				{
					continue;
				}
				else
				{
					Destroy(recipeDisplays[patron].gameObject);
					recipeDisplays.Remove(patron);
				}
			}
		}
	}
}