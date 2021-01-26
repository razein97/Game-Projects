using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    float cubeDamage = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(cubeDamage);
        Handheld.Vibrate();
    }
}
