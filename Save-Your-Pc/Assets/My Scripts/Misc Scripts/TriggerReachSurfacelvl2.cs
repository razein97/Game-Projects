using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class TriggerReachSurfacelvl2 : MonoBehaviour
    {

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
                PlayerStats ps = other.GetComponent<PlayerStats>();
                ps.islevel2Objective2Completed = true;
            }
        }
    }

}

