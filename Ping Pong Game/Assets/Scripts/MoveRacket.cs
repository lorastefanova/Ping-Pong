using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {

	[SerializeField]
	private float speed = 5.0f;
	[SerializeField]
	private string axis = "Vertical";


	//Called multiple times in a fixed time span
	void FixedUpdate (){
		//  This will return 1 when pressing either the W key, the UpArrow key, 
		//  or when pointing a gamepad's stick upwards. It will return -1 when using the S key, 
		//  the DownArrow key, or when pointing a gamepad's stick downwards. 
		float v = Input.GetAxisRaw (axis);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;
	}
}
