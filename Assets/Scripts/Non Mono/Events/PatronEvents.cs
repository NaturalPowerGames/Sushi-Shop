using System;
using UnityEngine;

public static class PatronEvents
{
	public static Action<PatronController> OnPatronEntered;
	public static Action<Vector3> OnPatronSitRequested;
}
