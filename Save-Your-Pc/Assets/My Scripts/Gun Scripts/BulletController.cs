using UnityEngine;

namespace MetaGameJam
{
    public class BulletController : MonoBehaviour
    {
        Rigidbody2D myRB;

        public float bulletSpeed;

        void OnEnable()
        {

        }

        void Awake()
        {
            myRB = GetComponent<Rigidbody2D>();
            if(transform.localRotation.z > 0)
            {
                myRB.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);
            }
            else
            {
                myRB.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse);
            }

            Destroy(this.gameObject, 5f);
        }
    }
}