using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour {
    private GameObject player;
    public GameObject projectile;
    public float shoot_distance;
    public float shoot_frecuency;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Character");
        StartCoroutine(shoot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator shoot(){
        while (true) {
            yield return new WaitForSeconds(shoot_frecuency);
            if (Vector3.Distance(player.transform.position, transform.position) < shoot_distance) {
                transform.LookAt(player.transform);
                Instantiate<GameObject>(projectile,transform.position,transform.rotation);
                print("Shoot");
                print(Vector3.Distance(player.transform.position, transform.position));
            }
        }
    }
}
