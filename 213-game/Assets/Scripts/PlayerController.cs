using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	void FixedUpdate(){
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveX, 0.0f, moveZ);
		GetComponent<Rigidbody>().velocity = movement;

	}
}