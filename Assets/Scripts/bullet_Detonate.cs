using UnityEngine;
using System.Collections;

public class bullet_Detonate : MonoBehaviour {

	float lifeSpan = 3.5f;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeSpan -= Time.deltaTime;

		if(lifeSpan < 0)
		{
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision coll){
		if(coll.transform.parent.tag == "enemy")
		{
			coll.transform.parent.tag = "dead";
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

}
