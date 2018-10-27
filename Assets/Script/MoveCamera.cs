using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public GameObject player;
    private float Offset;
	// Use this for initialization
	void Start () {
        Offset = transform.position.x - player.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

//        transform.position = player.transform.position + Offset;
	}

    private void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + Offset, transform.position.y, transform.position.z);
    }
}
