using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	Rigidbody body;
	
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		if (gameOver) {
			
			if (Input.GetMouseButtonDown(0)) {
				SceneManager.LoadScene("Game");
			}
			return;
		}
		if (Input.GetMouseButton(0)) {
			body.AddForce(new Vector3(0, 50,0), ForceMode.Acceleration);
		} else if (Input.GetMouseButtonUp(0)) {
			body.velocity *= 0.25f;
		}
	}
	
	void OnTriggerEnter(Collider collider) {
		gameOver = true;
		body.isKinematic = true;
	}
}
