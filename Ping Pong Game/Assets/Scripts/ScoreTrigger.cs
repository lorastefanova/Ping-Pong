using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {
	[SerializeField]
	private CountScore cs;
	[SerializeField]
	private BallMovement bm;

	//Check if ball is over the line and update score value
	void OnTriggerEnter2D (Collider2D BallCheck){
		Debug.Log ("Ball crossed the line");
		Debug.Log (BallCheck.name);

		//Check to see if it is the ball that has passed the line
		if (BallCheck.name == "Ball") {
			cs.UpdateScoreValue (1);
		}
		Debug.Log (gameObject.name);

		//Trigger the ball either left or right
		if (gameObject.name == "RightScore"){
			bm.reset("Right");
		}
		else if (gameObject.name == "LeftScore"){
				bm.reset("Left");
		}
	
	}
}
