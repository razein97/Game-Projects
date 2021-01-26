using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class PlayerDieTrigger : MonoBehaviour
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
                ps.playerHealth -= 100f;
                ps.numberOfLives = 0;
            }
        }
    }

}

