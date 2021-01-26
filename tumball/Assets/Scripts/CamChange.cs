using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {

   // public GameObject camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("cam_top"))
        {
            Camera.main.GetComponent<CameraController>().enabled = false;
            Camera.main.GetComponent<CameraController2>().enabled = true;

        }

        if (other.gameObject.CompareTag("cam_norm"))
            {
            Camera.main.GetComponent<CameraController>().enabled = true;
            Camera.main.GetComponent<CameraController2>().enabled = false;

        }
    }
}
