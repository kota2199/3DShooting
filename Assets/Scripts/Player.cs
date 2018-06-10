using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
Rigidbody rb;
private float speed = 5f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void Update () {
	}
	public void GoRight(){
		Debug.Log("right");
rb.velocity = new Vector3(-1, 0, 0) * speed;
	}
	public void GoLeft(){
		Debug.Log("left");
rb.velocity = new Vector3(1, 0, 0) * speed;
	}
}
