using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterAnimationHook animationHook;
	private MovementController movement;
	public Transform testStation;

	private void Awake()
	{
		movement = GetComponent<MovementController>();
	}
	private void Start()
	{
		OnPlayerMoveToStationRequested(testStation.position);
	}

	private void OnEnable()
	{
		PlayerEvents.OnPlayerMoveToStationRequested += OnPlayerMoveToStationRequested;
	}

	private void OnPlayerMoveToStationRequested(Vector3 location)
	{
		movement.MoveTo(location, () => OnStationReached());
	}

	private void OnStationReached()
	{
		//do the standing animation and rotate correctly
		Debug.Log("Reached station :X");
	}
}
