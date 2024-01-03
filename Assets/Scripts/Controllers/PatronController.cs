using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronController : MonoBehaviour
{
	private MovementController movement;
	public Transform chairTarget;
	private CharacterAnimationHook animationHook;

	private void Awake()
	{
		movement = GetComponent<MovementController>();
		//create animation hook
	}

	private void Start()
	{
		OnPatronSitRequested(chairTarget.transform.position);
	}

	private void OnEnable()
	{
		PatronEvents.OnPatronSitRequested += OnPatronSitRequested;
	}

	private void OnDisable()
	{
		PatronEvents.OnPatronSitRequested -= OnPatronSitRequested;
	}

	private void OnPatronSitRequested(Vector3 chairLocation)
	{
		movement.MoveTo(chairLocation, () => OnChairLocationReached());
	}

	private void OnChairLocationReached()
	{
		//do the sitting animation and rotate correctly
		Debug.Log("Reached location :X");
	}
}
