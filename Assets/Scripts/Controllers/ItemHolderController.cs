using System;
using UnityEngine;

public class ItemHolderController : MonoBehaviour
{
	[SerializeField]
	private Transform[] holdLocations; 

	public void HoldItem(GameObject item)
	{
		item.transform.SetParent(FindNextHoldLocation());
		item.transform.localPosition = Vector3.zero;
		item.transform.localEulerAngles = Vector3.zero;
	}

	public void TransferItem(Transform target)
	{
		//??
	}

	private Transform FindNextHoldLocation()
	{
		return Array.Find(holdLocations, (x) => x.childCount == 0);
	}
}
