using System;
using UnityEngine;

public static class PatronEvents
{
	public static Action<PatronController> OnPatronEnteredRestaurant;
	public static Action<Recipe> OnPatronSat;
	public static Action<Vector3> OnPatronSitRequested;
}
