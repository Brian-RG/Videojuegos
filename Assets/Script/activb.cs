using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activb : MonoBehaviour {
    private Animator a;
    public GameObject activar;

    void Start () {
        a = GetComponent<Animator>();
	}

	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            a.SetBool("p", true);
            activar.SetActive(false);
            //gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {   if (collision.gameObject.layer == 8)
        {
            a.SetBool("p", false);
            gameObject.GetComponent<Renderer>().enabled = true;
            //activar.SetActive(true);
        }
    }
}
