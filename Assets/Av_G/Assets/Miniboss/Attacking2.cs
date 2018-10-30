using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MiniBoss.velocidadBala = MiniBoss.velocidadBala + 0.1f;
        gameObject.transform.localScale += new Vector3(-0.3f,-0.3f,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
