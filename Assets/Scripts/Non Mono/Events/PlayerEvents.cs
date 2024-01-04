using System;
using UnityEngine;

public static class PlayerEvents
{
	public static Action<Vector3> OnPlayerMoveToStationRequested;
	public static Action OnIngredientRequested;
	public static Action<GameObject> OnPlayerHoldItemRequested;
}
