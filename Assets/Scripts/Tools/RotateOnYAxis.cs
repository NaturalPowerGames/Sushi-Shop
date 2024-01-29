using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnYAxis : MonoBehaviour
{
    public float rate;

	private void Update()
	{
		transform.Rotate(Vector3.forward, UnityEngine.Random.Range(rate * 0.5f, rate *2f) * Time.deltaTime);
	}
}
