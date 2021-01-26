using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class PlatformDisappear : MonoBehaviour
    {

        public GameObject platformToDisappear;

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
            if(other.tag == "Player")
            {
                platformToDisappear.SetActive(false);
            }
        }
    }
}



