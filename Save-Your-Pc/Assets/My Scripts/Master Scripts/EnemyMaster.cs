using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class EnemyMaster : MonoBehaviour
    {
        public static EnemyMaster Instance;
        public float Enemy1Damage = 10f;

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

        }

        void SetInitialReferences()
        {
            Instance = this;
        }
    }

}


