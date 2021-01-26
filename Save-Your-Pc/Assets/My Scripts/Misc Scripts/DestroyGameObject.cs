using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class DestroyGameObject : MonoBehaviour
    {


        public float timeToWaitUntilDestruction;

        void Awake()
        {
            StartCoroutine(Destroy());
        }

        private IEnumerator Destroy()
        {
            yield return new WaitForSeconds(timeToWaitUntilDestruction);
            Destroy(this.gameObject);
        }
    }

}
