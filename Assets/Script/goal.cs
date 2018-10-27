using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hi team");
    }
}
