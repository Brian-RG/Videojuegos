using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveChar : MonoBehaviour {

    private Animator animator;
    private float j;
    private Rigidbody2D r;
    private bool alive = true;
    private bool inair = false;
    Vector3 spawnpoint;
    private int vidas=3;
    public Text texto;

    public 
    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
        r = GetComponent<Rigidbody2D>();
        j = 0;
        spawnpoint = transform.position;
    }

    // Update is called once per frame
    void Update() {
        float v = Input.GetAxisRaw("Horizontal");
        float jActual = Input.GetAxisRaw("Jump");
        animator.SetFloat("Velocity", v);
        if (alive)
        {
            transform.Translate(v * Time.deltaTime * 5, 0, 0);
        }
        if (j != jActual && jActual == 1) {
            if (alive && !inair)
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
        var q = collision.gameObject.layer;
        if (q == 4)
        {
            if (alive)
            {
                animator.SetTrigger("touch");
                r.AddForce(new Vector2(-4, 4), ForceMode2D.Impulse);
                StartCoroutine(spawn(1.5f));
            }

        }
        else if (q == 5)
        {
            r.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            inair = true;
        }
        else if (q == 9)
        {
            StartCoroutine(spawn(.8f));
        }

        else if (q == 10)
        {
            animator.SetBool("pushing",true);
            inair = false;
        }

        else if (q == 12)
        {
            animator.SetTrigger("won");
            animator.SetFloat("Velocity", 0);
            Destroy(this);
        }

        else {
            inair = false;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
            animator.SetBool("pushing", false);
    }

    private void updatelives()
    {
        vidas -= 1;
        if (vidas == 1)
        {
            this.texto.text = vidas + " vida";
        }
        else { 
            this.texto.text = vidas + " vidas";
        }
    }

    IEnumerator spawn(float x)
    {
        this.alive = false;
        if (this.vidas > 1)
        {
            yield return new WaitForSeconds(x);
            updatelives();
            this.alive = true;
            animator.SetTrigger("respawn");
            transform.position = spawnpoint;
        }
        else
        {
            alive = false;
        }
    }

}
