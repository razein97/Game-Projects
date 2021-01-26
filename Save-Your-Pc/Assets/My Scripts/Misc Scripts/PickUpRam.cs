using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class PickUpRam : MonoBehaviour
    {
        public GameObject objective;
        public GameObject lvl2obj1scr;
        public GameObject lvl2obj2scr;
        public GameObject triggerGetToSurface;
        

        void OnEnable()
        {
            
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                PlayerStats ps = other.GetComponent<PlayerStats>();
                if(this.gameObject.tag == "Ram1")
                {
                    ps.islevel1Objective1Completed = true;
                    objective.SetActive(false);
                    this.gameObject.SetActive(false);

                }
                else if(this.gameObject.tag == "Ram2")
                {
                    ps.islevel1Objective2Completed = true;
                    objective.SetActive(false);
                    this.gameObject.SetActive(false);
                }
                else if(this.gameObject.tag == "CPU")
                {
                    ps.islevel1Objective3Completed = true;
                    objective.SetActive(false);
                    this.gameObject.SetActive(false);
                }
                else if(this.gameObject.tag == "GPU")
                {
                    triggerGetToSurface.SetActive(true);
                    objective.SetActive(false);
                    ps.islevel2Objective1Completed = true;
                    lvl2obj1scr.SetActive(false);
                    lvl2obj2scr.SetActive(true);
                    this.gameObject.SetActive(false);
                    //StartCoroutine(ShowBitcoin(ps));
                    
                }
     

                
            }

            
        }

        IEnumerator ShowBitcoin(PlayerStats ps)
        {
            yield return new WaitForSeconds(1f);
            

        }
    }

}
