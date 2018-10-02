using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour {
    Vector3 pos;
    private float direccion = -0.5f;
    private float savedTime;

	// Use this for initialization
	void Start () {
        pos = gameObject.transform.position;
        savedTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.Translate(pos.x * direccion * Time.deltaTime, 0, 0);

        /*if (Time.time - savedTime <= 1)
        {
            gameObject.transform.Translate(pos.x * direccion * Time.deltaTime, 0, 0);
        }
       
        else
        {
            direccion = direccion * -1;
            savedTime = Time.time;
        }*/

    }

    /*void OnCollisionEnter2D(Collision collision)
    {
        direccion = direccion * (-1);
        Debug.Log("Hola");
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==2 || collision.gameObject.layer==1)
        direccion = direccion * -1;
    }

}
