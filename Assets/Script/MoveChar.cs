using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour {

    private Animator animator;
    private float j;
    private Rigidbody2D r;
    private bool rip = true;
    private bool inair = false;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        r = GetComponent<Rigidbody2D>();
        j = 0;
    }
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw("Horizontal");
        float jActual = Input.GetAxisRaw("Jump");
        animator.SetFloat("Velocity", v);
        if (rip)
        {
            transform.Translate(v * Time.deltaTime * 5, 0, 0);
        }
        if (j != jActual && jActual == 1) {
            if (rip && !inair)
            {
                animator.SetTrigger("salto");
                r.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
                inair = true;
            }
        }
        j = jActual;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 4)
        {
            if (rip)
            {
                animator.SetTrigger("touch");
                r.AddForce(new Vector2(-4, 4), ForceMode2D.Impulse);
            }
            rip = false;
        }
        else if (collision.gameObject.layer == 5)
        {
            r.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            inair = true;
            //Debug.Log(Mathf.Clamp(4f, 1f, 10f));
        }
        else {
            inair = false;
        }
    }
}
