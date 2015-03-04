using UnityEngine;
using System.Collections;

public class FirstPersonShoot : MonoBehaviour {


	public GameObject Bullet_prefab;
	public float bulletImpulse = 100f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if( Input.GetButtonDown ("Fire1")) {
			Camera cam = Camera.main;
			GameObject bullet = (GameObject)Instantiate(Bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			bullet.gameObject.rigidbody.AddForce(bulletImpulse * cam.transform.forward, ForceMode.Impulse);
		}
	}
}
