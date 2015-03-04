using UnityEngine;
using System.Collections;

public class NoRotate : MonoBehaviour {
	
	Vector3 offset;
	Quaternion rotation;
	// Use this for initialization
	void Start () {
		rotation = this.transform.rotation;
		offset = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = rotation;
		transform.localPosition = offset;
	}
}
