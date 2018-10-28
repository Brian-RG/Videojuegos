using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour {
    public Transform player;
    public GameObject projectile;

	// Use this for initialization
	void Start () {
        StartCoroutine(shoot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator shoot(){
        while (true) {
            yield return new WaitForSeconds(1);
            if (Vector3.Distance(player.position, transform.position) < 10) {
                Instantiate<GameObject>(projectile);
                print("Shoot");
                print(Vector3.Distance(player.position, transform.position));
            }
        }
    }
}
