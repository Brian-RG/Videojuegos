using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss : MonoBehaviour {
    public GameObject bala;
    public GameObject pos;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;

    public static float velocidadBala;
    private bool coll = false;
    private Estado actual,
                   anterior;
    private Estado attacking1,
                   attacking2,
                   attacking3,
                   attacking4,
                   attacking5,
                   dead;
    private Simbolo pierdeVida;
    private Component scriptActual;
   

	// Use this for initialization
	void Start () {
        attacking1 = new Estado("attacking1", typeof(Attacking1));
        attacking2 = new Estado("attacking1", typeof(Attacking2));
        attacking3 = new Estado("attacking1", typeof(Attacking3));
        attacking4 = new Estado("attacking1", typeof(Attacking4));
        attacking5 = new Estado("attacking1", typeof(Attacking5));
        dead = new Estado("dead", typeof(Dead));

        pierdeVida = new Simbolo("pierdeVida");

        attacking1.definirTransicion(pierdeVida, attacking2);
        attacking2.definirTransicion(pierdeVida, attacking3);
        attacking3.definirTransicion(pierdeVida, attacking4);
        attacking4.definirTransicion(pierdeVida, attacking5);
        attacking5.definirTransicion(pierdeVida, dead);

        actual = attacking1;
        anterior = actual;
        scriptActual = gameObject.AddComponent(actual.Tipo);

        System.Type type = typeof(Attacking1);

        velocidadBala = 0.0f;
        StartCoroutine(disparar());
	}

    void transitar(Simbolo simbolo)
    {
        actual = actual.aplicarSimbolo(simbolo);
        if (anterior == actual)
        {
            return;
        }
        anterior = actual;
        Destroy(scriptActual);
        scriptActual = gameObject.AddComponent(actual.Tipo);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnCollisionExit2D(Collision2D collision)
    {
        transitar(pierdeVida);
    }

    IEnumerator disparar()
    {
        while (true)
        {
            yield return new WaitForSeconds(velocidadBala);
            Instantiate<GameObject>(bala, pos.transform.position, pos.transform.rotation);
            Instantiate<GameObject>(bala, pos2.transform.position, pos2.transform.rotation);
            Instantiate<GameObject>(bala, pos3.transform.position, pos3.transform.rotation);
            Instantiate<GameObject>(bala, pos4.transform.position, pos4.transform.rotation);
        }
    }
}
