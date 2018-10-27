using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    public GameObject activar;

	// Use this for initialization
	void Start () {
        //activar = GetComponent<GameObject>();
        activar.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
    }


    void OnCollisionStay(Collision collision)
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.layer == 8)
        {
            activar.SetActive(false);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.layer == 8)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            activar.SetActive(true);
        }
    }
}
