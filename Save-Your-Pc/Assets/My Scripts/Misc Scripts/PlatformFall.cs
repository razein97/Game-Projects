using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class PlatformFall : MonoBehaviour
    {

        public Rigidbody2D[] rb;

        void OnEnable()
        {

        }

        void OnDisable()
        {

        }

        void Start()
        {

        }

        void Update()
        {

        }

        void SetInitialReferences()
        {

        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                foreach (Rigidbody2D rigidBody in rb)
                {
                    rigidBody.isKinematic = false;

                    Destroy(this.gameObject, 10f);
                }
            }
        }
    }

}

