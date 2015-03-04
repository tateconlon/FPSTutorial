using UnityEngine;
using System.Collections;

public class PerformAttack : MonoBehaviour {

	public float range = 0.75f;
	public GameObject debrisPrefab;
	public float damage = 10f;

	public float shotCooldown = 0.2f;
	float cooldownRemaining = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cooldownRemaining -= Time.deltaTime;
		if(Input.GetMouseButton(0) && cooldownRemaining <= 0){
				cooldownRemaining = shotCooldown;
				
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;

			if(Physics.Raycast(ray, out hitInfo, range)){
				Vector3 worldPoint = hitInfo.point;
				GameObject go = hitInfo.collider.gameObject;
				string goName = go.name;
				Debug.Log ("Hit: " + goName + worldPoint);
				Debug.Log ("Distance: " + hitInfo.distance);
				Quaternion orientation = Quaternion.LookRotation(hitInfo.normal);

				HasHealth h = go.GetComponent<HasHealth>();

				if(h != null)
					h.RecieveDamage(damage);

				Instantiate(debrisPrefab, worldPoint, orientation);
			}
		}
	}
}
