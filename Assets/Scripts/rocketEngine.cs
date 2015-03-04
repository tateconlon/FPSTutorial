using UnityEngine;
using System.Collections;

public class rocketEngine : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (transform.forward * speed * Time.deltaTime, Space.World);
	}
}
