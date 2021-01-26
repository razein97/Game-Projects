using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class CameraFollow : MonoBehaviour
    {

        public Transform target;

        float smoothSpeed = 20f;
        public Vector3 offset;


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

        void FixedUpdate()
        {
            Vector3 desiredPositon = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}

