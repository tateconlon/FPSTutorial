using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class FirstPersonPlayer : MonoBehaviour {

	public float moveSpeed = 10;
	public float mouseSensitivity = 5;
	public float upDownRange = 30;	//Degrees
	public float jumpSpeed = 7;
	
	float vertVelocity = 0;
	float verticalRotation = 0;
	float horizontalRotation = 0;
	CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {

		float horzRot = Input.GetAxis ("Mouse X") * mouseSensitivity;

			transform.Rotate(0, horzRot, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);

		Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0);
	
		vertVelocity += Physics.gravity.y * Time.deltaTime;

		if(Input.GetButtonDown ("Jump") && cc.isGrounded)
		{
			vertVelocity = jumpSpeed;
		}

		float forwardSpeed = Input.GetAxis ("Vertical") * moveSpeed;
		float horizontalSpeed = Input.GetAxis ("Horizontal") * moveSpeed;
		Vector3 speed = new Vector3(horizontalSpeed,vertVelocity,forwardSpeed);


		speed = transform.rotation * speed;

		cc.Move(speed * Time.deltaTime);

	}
}
