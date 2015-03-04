using UnityEngine;
using System.Collections;

public class PerformAttackProjectile : MonoBehaviour {

	public GameObject rocketPrefab;
	public float shotCooldown = 0.2f;
	float cooldownRemaining = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cooldownRemaining -= Time.deltaTime;
		if(Input.GetMouseButton(1) && cooldownRemaining <= 0){
				cooldownRemaining = shotCooldown;

			Instantiate(rocketPrefab, Camera.main.transform.position , Camera.main.transform.rotation);
		}
	}
}
