using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{

    public class HoverScript : MonoBehaviour
    {

        

        public GameObject forwardThrust; //This is the back thruster
        public GameObject forwardThrustOverlay;
        public GameObject downThrust1; //This is the down thruster 1
        public GameObject downThrust2;
        public GameObject downThrust1_1;
        public GameObject downThrust2_1;
        public Rigidbody2D playerRigidBody;

        public float minSpeed = 10f;

        public LayerMask hoverLayer;
        public float hoverForce = 10f;
        public float hoverHeight = 4f;
        public GameObject hoverPoint;
        

        
        
        

        void OnEnable()
        {
            SetInitialReferences();
            
        }

        void OnDisable()
        {
            
        }

        void Start()
        {
           

        }

        void Update()
        {
            if (Input.GetButton("Hover Up"))
            {
                downThrust1_1.SetActive(true);
                downThrust2_1.SetActive(true);
            }
            else
            {
                downThrust1_1.SetActive(false);
                downThrust2_1.SetActive(false);
            }



        }

        void FixedUpdate()
        {
            float currSpeed = playerRigidBody.velocity.magnitude;
            

            if(currSpeed > minSpeed)
            {
                forwardThrustOverlay.SetActive(true);
            }
            else
            {
                forwardThrustOverlay.SetActive(false);   
            }

           
        }

        void SetInitialReferences()
        {
            
            
        }

        void Reset()
        {
            forwardThrust = GameObject.Find("Thruster 3.1");
            forwardThrustOverlay = GameObject.Find("Thruster 3.1 (1)");
            downThrust1 = GameObject.Find("Thruster 1");
            downThrust2 = GameObject.Find("Thruster 2");
            playerRigidBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        }

        void Hover()
        {
            //Hover Force will be applied
            RaycastHit hit;

            if (Physics.Raycast(hoverPoint.transform.position, -Vector3.up, out hit, hoverHeight, hoverLayer))
            {
                playerRigidBody.AddForceAtPosition(-Vector3.up * hoverForce * (1.0f - (hit.distance / hoverHeight)), hoverPoint.transform.position);
            }
            else
            {

                if (transform.position.y > hoverPoint.transform.position.y)
                {
                    playerRigidBody.AddForceAtPosition(hoverPoint.transform.up * hoverForce, hoverPoint.transform.position);
                }
                else
                {
                    playerRigidBody.AddForceAtPosition(hoverPoint.transform.up * -hoverForce, hoverPoint.transform.position);
                }
            }

        }

        
    }

}

