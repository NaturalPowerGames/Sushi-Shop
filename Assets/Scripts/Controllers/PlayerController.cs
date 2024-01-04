using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterAnimationHook animationHook;
	private MovementController movement;
	[SerializeField]
	private ItemHolderController itemHolder;

	private void Awake()
	{
		movement = GetComponent<MovementController>();
		itemHolder = GetComponentInChildren<ItemHolderController>();
	}

	private void OnEnable()
	{
		PlayerEvents.OnPlayerMoveToStationRequested += OnPlayerMoveToStationRequested;
		PlayerEvents.OnPlayerHoldItemRequested += OnPlayerHoldItemRequested;
	}

	private void OnDisable()
	{
		PlayerEvents.OnPlayerMoveToStationRequested += OnPlayerMoveToStationRequested;
		PlayerEvents.OnPlayerHoldItemRequested -= OnPlayerHoldItemRequested;
	}

	private void OnPlayerHoldItemRequested(GameObject item)
	{
		itemHolder.HoldItem(item);
	}

	private void OnPlayerMoveToStationRequested(Vector3 location)
	{
		movement.MoveTo(location, () => OnStationReached());
	}

	private void OnStationReached()
	{
		//do the standing animation and rotate correctly
		PlayerEvents.OnIngredientRequested?.Invoke();
		Debug.Log("Reached station :X");
	}
}
