using Cooking;
using Patrons;
using System;
using UnityEngine;
using System.Collections.Generic;

public static class PatronEvents
{
	public static Action<PatronController> OnPatronEntered;
	public static Action<Vector3> OnPatronSitRequested;
	public static Action<PatronController> OnPatronSat;
	public static Action<PatronController> OnPatronSatisfied;
	public static Action<Dictionary<PatronController, Recipe>> OnPatronRequirementsChanged;
	public static Action<Vector3> OnPatronLeaveRestaurantRequested;
	public static Action OnPatronLeft;

}
