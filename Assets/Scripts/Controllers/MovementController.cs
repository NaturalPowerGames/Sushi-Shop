using System;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
	private NavMeshAgent agent;
	private Action onLocationReached;

	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	internal void MoveTo(Vector3 destination, Action onLocationReached)
	{
		this.onLocationReached = onLocationReached;
		agent.SetDestination(destination);
	}

	private void Update()
	{
		if(agent.hasPath && agent.remainingDistance <= 0.15f)
		{
			onLocationReached?.Invoke();
			onLocationReached = null;
		}
	}
}
