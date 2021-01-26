using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class SawMove : MonoBehaviour
    {

        public Transform[] patrolPoints;
        public float moveSpeed;
        private int currentPoint;
        public float rotateSpeed = 10f;

        // Use this for initialization
        void Start()
        {
            transform.position = patrolPoints[0].position;
            currentPoint = 0;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime * rotateSpeed);

            if (transform.position == patrolPoints[currentPoint].position)
            {
                currentPoint++;
            }
            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;
            }

            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);
        }

    }

}

