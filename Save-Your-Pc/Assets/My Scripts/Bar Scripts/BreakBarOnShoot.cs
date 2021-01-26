using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class BreakBarOnShoot : MonoBehaviour
    {

        public GameObject bar1;
        public GameObject bar1Replacement;

        private float health = 100f;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Bullet")
            {
                health -= 3f;
                Destroy(other.gameObject);

                if (health <= 50)
                {
                    bar1.SetActive(false);
                    bar1Replacement.SetActive(true);
                }

                if (health <= 0)
                {

                    bar1Replacement.SetActive(false);

                    Destroy(this.gameObject);
                }
            }
        }


    }
}

