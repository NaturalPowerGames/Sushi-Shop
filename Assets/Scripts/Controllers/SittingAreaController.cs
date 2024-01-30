using Patrons;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SittingAreaController : MonoBehaviour
{
	[SerializeField]
	private Transform[] chairs;

	private void OnEnable()
	{
		PatronEvents.OnPatronEntered += OnPatronEntered;
	}

	private void OnDisable()
	{
		PatronEvents.OnPatronEntered -= OnPatronEntered;
	}

	private void OnPatronEntered(PatronController obj)
	{
		PatronEvents.OnPatronSitRequested?.Invoke(RandomNotOccupiedChair());
	}

	private Transform RandomNotOccupiedChair()
	{
		return chairs[0];
	}
}
