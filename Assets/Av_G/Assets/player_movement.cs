using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
	public float speed;
	public float jump;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		// nuevo problema de física
		// tiempo transcurrido entre el frame anterior y este
		// Time.deltaTime
		transform.Translate(
			h * speed * Time.deltaTime, 
			v * speed * Time.deltaTime * jump, 
			0, 
			Space.World);
	
	}
}
