using Cooking;
using System;
using UnityEngine;

public class IngredientStationManager : MonoBehaviour
{
	private IngredientStationController selectedStation;
	private IngredientsData ingredientsData;

	private void OnEnable()
	{
		CookingEvents.OnIngredientStationSelected += OnIngredientStationSelected;
		PlayerEvents.OnIngredientRequested += OnIngredientRequested;
	}
	private void OnDisable()
	{
		CookingEvents.OnIngredientStationSelected -= OnIngredientStationSelected;
		PlayerEvents.OnIngredientRequested -= OnIngredientRequested;
	}

	private void OnIngredientStationSelected(IngredientStationController selectedStation)
	{
		this.selectedStation = selectedStation;
	}

	private void OnIngredientRequested()
	{
		selectedStation?.GenerateAndGiveIngredientToPlayer();
		selectedStation = null;
	}
}
