using System;
using UnityEngine;
using System.Collections;

namespace MetaGameJam
{
    public class GunShoot : MonoBehaviour
    {
        AudioManager am;
        public Animator myAnimator;   
        private PlayerMovement playerMovement;
        public ParticleSystem muzzleFlash;
        public Transform firePoint;
        public GameObject bulletPrefab;
        float fireRate = 0.2f;
        float nextFire = 0f;

        void OnEnable()
        {
            SetInitialReferences();
            
        }

        void Update()
        {
            if(Input.GetAxisRaw("Fire1") > 0)
            {
                muzzleFlash.Play();
                Shoot();
            }
            else
            {
                muzzleFlash.Stop();
            }

            
        }

        void Shoot()
        {
            
            if(Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                am.Play("Machine Gun");

                firePoint.position = firePoint.transform.position + UnityEngine.Random.insideUnitSphere * 0.05f;
                if (playerMovement.facingRight)
                {
                    Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                    muzzleFlash.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
                }else if (!playerMovement.facingRight)
                {
                    Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
                    muzzleFlash.transform.localScale = new Vector3 (-2.0f, 2.0f,2.0f);
                }
            }
        }

        
        void SetInitialReferences()
        {
            playerMovement = GetComponent<PlayerMovement>();
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        }

       
    }
}