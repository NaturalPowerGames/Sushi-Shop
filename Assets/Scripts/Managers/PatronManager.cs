using System;
using System.Collections;
using UnityEngine;

namespace Patrons
{
	public class PatronManager : MonoBehaviour
	{
		[SerializeField]
		private Transform entryPoint;
		[SerializeField]
		private PatronData patronData;

		private void Start()
		{
			StartCoroutine(SummonPatronsWithWaitInBetween());
			OnPatronRequested();
		}

		private IEnumerator SummonPatronsWithWaitInBetween()
		{
			while (true)
			{
				yield return new WaitForSeconds(15);
				OnPatronRequested();
			}
		}

		private void OnEnable()
		{
			PatronEvents.OnPatronRequested += OnPatronRequested;
		}

		private void OnDisable()
		{
			PatronEvents.OnPatronRequested -= OnPatronRequested;
		}

		private void OnPatronRequested()
		{
			PatronController patron = Instantiate(patronData.GetRandomPatron());
			patron.transform.position = entryPoint.position;
			PatronEvents.OnPatronEntered?.Invoke(patron);
		}
	}
}