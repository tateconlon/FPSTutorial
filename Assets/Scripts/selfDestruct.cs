using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {

	public float duration = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(!PauseManager.isPaused){
		duration -= Time.deltaTime;
		if(duration <= 0){
			Destroy(gameObject);
		}
		//}
	}
}
