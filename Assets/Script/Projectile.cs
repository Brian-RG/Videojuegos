using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,0,0.1f,Space.Self);
	}
}
