using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IngredientStationController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private IngredientController ingredientPrefab;

	public void GenerateAndGiveIngredientToPlayer()
	{
		IngredientController ingredient = Instantiate(ingredientPrefab);
		PlayerEvents.OnPlayerHoldItemRequested?.Invoke(ingredient.gameObject);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		PlayerEvents.OnPlayerMoveToStationRequested?.Invoke(this.transform.position);
		CookingEvents.OnIngredientStationSelected?.Invoke(this);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
