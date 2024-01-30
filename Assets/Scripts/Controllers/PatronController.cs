using UnityEngine;
using Cooking;

namespace Patrons
{
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

		private void OnEnable()
		{
			PatronEvents.OnPatronSitRequested += OnPatronSitRequested;
		}

		private void OnDisable()
		{
			PatronEvents.OnPatronSitRequested -= OnPatronSitRequested;
		}

		private void OnPatronSitRequested(Transform chair)
		{
			movement.MoveTo(chair.position, () => OnChairLocationReached());
		}

		private void OnChairLocationReached()
		{
			//do the sitting animation and rotate correctly
			Debug.Log("Reached location :X");
			//do the sitting animation and rotate correctly (rotate where?)
			PatronEvents.OnPatronSat?.Invoke(this);
		}
	}
}