using UnityEngine;
using System.Collections;

public class DependenciesOnHit : MonoBehaviour {

	void OnCollisionEnter()
	{
		Debug.Log("Collision Hit");
	}

	void OnTriggerEnter()
	{
		Debug.Log ("Trigger Hit");
	}
}
